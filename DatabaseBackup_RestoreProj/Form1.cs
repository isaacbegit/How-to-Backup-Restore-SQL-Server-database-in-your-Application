using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackup_RestoreProj
{
    // Coded by Isaacbe (www.isaacbe.com);
    // for more details follow this link : 
    //https://isaacbe.com/how-to-backup-restore-sql-server-database-in-your-application/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sel_backupFOlder_Click(object sender, EventArgs e)
        {
            List<string> Lstdata = new List<string>();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DirectoryInfo dir = new DirectoryInfo(dialog.FileName);
                txt_foder_backup.Text = dir.ToString();
                Lstdata.Add(dir.ToString());
                File.WriteAllLines("backupsettings", Lstdata.ToArray());
            }

            lb_currentDatabase.Text = "Current database " ;

        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            btn_backup.Enabled = false;

            try
            {
                string backupName = "db_IMSC" + "_" + DateTime.Now.ToString("ddMMyyyy_HH.mm.ss") + ".bak";
                Server dbServer = new Server(new ServerConnection("server name",
                    "User Name", "Password"));

                Backup _backup = new Backup()
                {
                    Action = BackupActionType.Database,
                    Database = "Database Name to be backed up",

                };
                _backup.Devices.AddDevice("backup folder path",DeviceType.File );
                _backup.Initialize = true;
                _backup.PercentComplete += DB_BackUp_PersentComplete;
                _backup.Complete += DB_Backup_Complete;
                _backup.SqlBackupAsync(dbServer);
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btn_backup.Enabled = true;

            }
        }


        private void DB_Backup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {

                lb_statues.Invoke(new Action(() => lb_statues.Text = e.Error.Message));
                btn_backup.Invoke(new Action(() => btn_backup.Enabled = true));
                
            }
        }

        private void DB_BackUp_PersentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            lb_statues.Invoke((MethodInvoker)delegate
            {
                lb_statues.Text = $"{e.Percent }%";
            });
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            try

            {
                btn_restore.Enabled = false;
                CloseAllConnection();
                string SelectedBk = dg_backups.SelectedRows[0].Cells[0].Value.ToString().Trim();
                string BackupdataBasePath = "your Backup Path";
                Server dbServer = new Server(new ServerConnection("Server name",
                   "User name", "Password"));

                Restore _Restore = new Restore()
                {
                    Database = "Database name to be restored",
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };

                _Restore.Devices.AddDevice(BackupdataBasePath, DeviceType.File);

                _Restore.PercentComplete += DB_Restore_PersentComplete;
                _Restore.Complete += DB_Restore_Complete;
                _Restore.SqlRestoreAsync(dbServer);

            }
            catch (Exception ex)
            {
                btn_restore.Enabled = true;
                MessageBox.Show(ex.Message);
            }
        }

        private void DB_Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {

                lb_statues.Invoke(new Action(() => lb_statues.Text = e.Error.Message));
                btn_restore.Invoke(new Action(() => btn_restore.Enabled = true));
            }
        }

        private void DB_Restore_PersentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();

            });

            lb_statues.Invoke((MethodInvoker)delegate
            {
                lb_statues.Text = $"{e.Percent }%";
            });
        }



        // function to close any opend database connections
        private void CloseAllConnection()
        {

            string script = File.ReadAllText("closesCons.sql"); //file included in debug folder 

            // split script on GO command
            IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);


            SqlConnection _connection =new SqlConnection ( "Your Connection string ");

            _connection.Open();
            foreach (string commandString in commandStrings)
            {
                if (commandString.Trim() != "")
                {
                    using (var command = new SqlCommand(commandString, _connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            _connection.Close();
            _connection.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

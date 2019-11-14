namespace DatabaseBackup_RestoreProj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btn_restore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_backup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_sel_backupFOlder = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lb_statues = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lb_currentDatabase = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dg_backups = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_foder_backup = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_backups)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(188)))), ((int)(((byte)(104)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Jura", 30F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(902, 92);
            this.label3.TabIndex = 28;
            this.label3.Text = "Database Backup / Restore";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_restore
            // 
            this.btn_restore.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btn_restore.Location = new System.Drawing.Point(767, 211);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(133, 57);
            this.btn_restore.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_restore.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_restore.StateCommon.Border.Rounding = 5;
            this.btn_restore.StateCommon.Border.Width = 1;
            this.btn_restore.TabIndex = 30;
            this.btn_restore.Values.Text = "Restore";
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btn_backup.Location = new System.Drawing.Point(767, 150);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(133, 57);
            this.btn_backup.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_backup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_backup.StateCommon.Border.Rounding = 5;
            this.btn_backup.StateCommon.Border.Width = 1;
            this.btn_backup.TabIndex = 31;
            this.btn_backup.Values.Text = "Backup";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_sel_backupFOlder
            // 
            this.btn_sel_backupFOlder.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom1;
            this.btn_sel_backupFOlder.Location = new System.Drawing.Point(687, 97);
            this.btn_sel_backupFOlder.Name = "btn_sel_backupFOlder";
            this.btn_sel_backupFOlder.Size = new System.Drawing.Size(73, 37);
            this.btn_sel_backupFOlder.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_sel_backupFOlder.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sel_backupFOlder.StateCommon.Border.Rounding = 5;
            this.btn_sel_backupFOlder.StateCommon.Border.Width = 1;
            this.btn_sel_backupFOlder.TabIndex = 32;
            this.btn_sel_backupFOlder.Values.Text = "Change";
            this.btn_sel_backupFOlder.Click += new System.EventHandler(this.btn_sel_backupFOlder_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(158, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(588, 23);
            this.progressBar1.TabIndex = 38;
            // 
            // lb_statues
            // 
            this.lb_statues.AutoSize = false;
            this.lb_statues.Location = new System.Drawing.Point(148, 141);
            this.lb_statues.Name = "lb_statues";
            this.lb_statues.Size = new System.Drawing.Size(598, 66);
            this.lb_statues.TabIndex = 36;
            this.lb_statues.Values.Text = "state";
            // 
            // lb_currentDatabase
            // 
            this.lb_currentDatabase.AutoSize = false;
            this.lb_currentDatabase.Location = new System.Drawing.Point(176, 250);
            this.lb_currentDatabase.Name = "lb_currentDatabase";
            this.lb_currentDatabase.Size = new System.Drawing.Size(570, 32);
            this.lb_currentDatabase.TabIndex = 37;
            this.lb_currentDatabase.Values.Text = "Current state";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(0, 274);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dg_backups);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(902, 267);
            this.kryptonGroupBox1.TabIndex = 35;
            this.kryptonGroupBox1.Values.Heading = "Backups";
            // 
            // dg_backups
            // 
            this.dg_backups.AllowUserToAddRows = false;
            this.dg_backups.AllowUserToDeleteRows = false;
            this.dg_backups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_backups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_backups.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dg_backups.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dg_backups.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dg_backups.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dg_backups.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet;
            this.dg_backups.Location = new System.Drawing.Point(0, 0);
            this.dg_backups.MultiSelect = false;
            this.dg_backups.Name = "dg_backups";
            this.dg_backups.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.dg_backups.ReadOnly = true;
            this.dg_backups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_backups.Size = new System.Drawing.Size(898, 243);
            this.dg_backups.TabIndex = 23;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(80, 102);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel7.TabIndex = 34;
            this.kryptonLabel7.Values.Text = "Backups Folder";
            // 
            // txt_foder_backup
            // 
            this.txt_foder_backup.Location = new System.Drawing.Point(176, 98);
            this.txt_foder_backup.Name = "txt_foder_backup";
            this.txt_foder_backup.ReadOnly = true;
            this.txt_foder_backup.Size = new System.Drawing.Size(505, 35);
            this.txt_foder_backup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_foder_backup.StateCommon.Border.Rounding = 5;
            this.txt_foder_backup.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(118)))), ((int)(((byte)(201)))));
            this.txt_foder_backup.StateCommon.Content.Font = new System.Drawing.Font("justagain DIN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_foder_backup.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 541);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb_statues);
            this.Controls.Add(this.lb_currentDatabase);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txt_foder_backup);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_sel_backupFOlder);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_backups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_restore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_backup;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sel_backupFOlder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_statues;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lb_currentDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dg_backups;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_foder_backup;
    }
}


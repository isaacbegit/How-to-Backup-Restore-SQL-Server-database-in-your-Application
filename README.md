# How-to-Backup-Restore-SQL-Server-database-in-your-Application
Backup and restore database feature in your application is very important feature that can be add in your application to easy make these operation by your clients who uses your application , let me discuss how it’s easy to develop this feature
**Script to release or close all sql server connections to database**
```
USE [master];
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('your database')
EXEC(@kill);
```
![alt text](https://github.com/esaaco/How-to-Backup-Restore-SQL-Server-database-in-your-Application/blob/master/db_backup_restore.jpg)

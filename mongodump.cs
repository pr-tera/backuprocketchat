using System;
using System.Diagnostics;
using System.IO;

namespace backuprocketchat
{
    class mongodump
    {
        public static bool Backup()
        {
            if (_backup() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool _backup()
        {
            Process backup = new Process();
            backup.StartInfo.Arguments = $"-c \" {Data.Mongodump} --host {Data.HostDB} --db {Data.RocketchatBase} --gzip --archive={Data.BackupPath + Data.DateTimeNow + Data.Type} \"";
            backup.StartInfo.FileName = Data.Bash;
            backup.StartInfo.RedirectStandardOutput = true;
            try
            {
                backup.Start();
                StreamReader streamReader = backup.StandardOutput;
                Data.Out = streamReader.ReadToEnd();
                backup.WaitForExit();
                if (Data.Out.Contains(Data.ReturnBackup))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

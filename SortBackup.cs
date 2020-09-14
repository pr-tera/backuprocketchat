using System;
using System.IO;

namespace backuprocketchat
{
    class SortBackup
    {
        public static bool SortB()
        {
            if (_sortB() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool _sortB()
        {
            bool _return = true;
            foreach (var backup in new DirectoryInfo(Data.BackupPath).EnumerateFiles(Data.Type, SearchOption.AllDirectories))
            {
                DateTime _CreatTime = backup.CreationTime;
                if (DateTime.Now - _CreatTime > TimeSpan.FromDays(Data.DayStorageBackup))
                {
                    if (IO.DeletFile(backup.FullName) == true)
                    {
                        _return = true;
                    }
                    else
                    {
                        _return = false;
                    }
                }
            }
            return _return;
        }
        public static bool SortF()
        {
            if (_sortF() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool _sortF()
        {
            bool _return = true;
            foreach (var backup in new DirectoryInfo(Data.FilePath).EnumerateFiles(Data.Type, SearchOption.AllDirectories))
            {
                DateTime _CreatTime = backup.CreationTime;
                if (DateTime.Now - _CreatTime > TimeSpan.FromDays(Data.DayStorageFile))
                {
                    if (IO.DeletFile(backup.FullName) == true)
                    {
                        _return = true;
                    }
                    else
                    {
                        _return = false;
                    }
                }
            }
            return _return;
        }
    }
}

using System;

namespace backuprocketchat
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IO.ExistDir(Data.BackupPath) == true)
            {
                if (mongodump.Backup() == true)
                {
                    if (SortBackup.SortB() == true)
                    {
                        //запись лога что всё ок 
                    }
                    else
                    { 
                        //не удалось удалить бекап
                    }
                    if (SortBackup.SortF() == true)
                    {
                        //запись лога что всё ок
                    }
                    else
                    { 
                        //не удалось удалить файл
                    }
                }
                else
                { 
                    //запись лога
                }
            }
            else
            { 
                //попытка монтировать папку.
            }
        }
    }
}

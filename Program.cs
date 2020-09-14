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
                        Data.Log += $"{Data.DateTimeNow} Старые бекапы удалены\n";
                    }
                    else
                    {
                        Data.Log += $"{Data.DateTimeNow} Не удалось удалить старые бекапы\n";
                    }
                    if (SortBackup.SortF() == true)
                    {
                        Data.Log += $"{Data.DateTimeNow} Прикреплённые файлы очищенны\n";
                    }
                    else
                    {
                        Data.Log +=  $"{Data.DateTimeNow} Не удалось удалить прикреплённые файлы\n";
                    }
                }
                else
                {
                    Data.Log += $"{Data.DateTimeNow}Не удалось выполнить резервное копирование\n";
                }
            }
            else
            {
                Data.Log += $"{Data.DateTimeNow} Папка не доступна\n";
            }
        }
    }
}

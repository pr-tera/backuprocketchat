using System;

namespace backuprocketchat
{
    struct Data
    {
        internal static string BackupPath { get; } = @"/mnt/RocketChatTemp/backup/";
        internal static string FilePath { get; } = @"/mnt/RocketChatTemp/rocket/";
        internal static string LogPath { get; } = @"/home/admin1c/Scripts/LogBackupRocketchat.log";
        internal static string DateTimeNow { get; } = DateTime.Now.ToString("yyyy:MM:dd");
        internal static string Mongodump { get; } = "mongodump";
        internal static string RocketchatBase { get; } = "rocketchat";
        internal static string Out { get; set; }
        internal static string Bash { get; } = @"/bin/bash";
        internal static string ReturnBackup { get; } = "system.indexes.bson";
        internal static string HostDB { get; } = "rocketchat.pr";
        internal static string Type { get; } = ".gz";
        internal static string Log { get; set; }
        internal static int DayStorageBackup = 10;
        internal static int DayStorageFile = 90;
    }
}

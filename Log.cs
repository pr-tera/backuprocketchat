using System.IO;

namespace backuprocketchat
{
    class Log
    {
        internal static void Write()
        {
            if (!string.IsNullOrEmpty(Data.Log))
            {
                using (FileStream fstream = new FileStream(Data.LogPath, FileMode.OpenOrCreate))
                {
                    using (StreamWriter sw = new StreamWriter(fstream, System.Text.Encoding.Default))
                    {
                        sw.Write(Data.Log);
                    }
                }
            }
        }
    }
}

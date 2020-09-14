using System.IO;

namespace backuprocketchat
{
    class IO
    {
        internal static bool ExistDir(string path)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (dir.Exists)
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
        internal static bool ExistFile(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                if (file.Exists)
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
        internal static bool DeletFile(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
                if (ExistFile(path) == true)
                {
                    file.Delete();
                    if (ExistFile(path) == false)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

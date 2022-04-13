using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetFileNameByTime
{
    public static class SetName
    {
        public static bool SetFileNameByTime(string dirSource, string dirTarget)
        {
            try
            {
                string[] filenames = Directory.GetFiles(dirSource);
                List<CompairableFileInfo> files = new List<CompairableFileInfo>();
                foreach (string filename in filenames)
                {
                    FileInfo fileInfo = new FileInfo(filename);
                    CompairableFileInfo compairableFileInfo = new CompairableFileInfo(fileInfo);
                    files.Add(compairableFileInfo);
                }

                files.Sort();
                Console.WriteLine(files.Count + " files");
                for(int i=0; i<files.Count; i++)
                {
                    File.Copy(files[i].Info.FullName, dirTarget + @"\" + (i + 1) + files[i].Info.Extension);
                    Console.WriteLine(files[i].Info.Name + " -> " + (i + 1) + files[i].Info.Extension);
                }

                Console.WriteLine("succeed");
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine("failed");
                //Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

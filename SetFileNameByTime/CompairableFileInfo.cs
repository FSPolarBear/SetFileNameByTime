using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SetFileNameByTime
{
    /// <summary>
    /// 根据最后修改时间对文件排序
    /// </summary>
    public class CompairableFileInfo:IComparable<CompairableFileInfo>
    {
        public FileInfo Info { get; private set; }

        public CompairableFileInfo(FileInfo Info)
        {
            this.Info = Info;
        }

        public int CompareTo(CompairableFileInfo? other)
        {
            return Info.LastWriteTime.CompareTo(other.Info.LastWriteTime) ;
        }


    }
}

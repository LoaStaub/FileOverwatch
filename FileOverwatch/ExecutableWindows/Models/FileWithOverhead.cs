using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.Models
{
    class FileWithOverhead
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileName { get; set; }
        public string Directory { get; set; }
        public string Description { get; set; }
        public DateTime LastAccess { get; set; }
        public byte[] Icon { get; set; }
        public bool Deleted { get; set; }
        public string GroupName { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public LinkedFile LinkedFile { get; set; }
    }
}
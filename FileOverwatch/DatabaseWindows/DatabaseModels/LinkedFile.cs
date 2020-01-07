using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class LinkedFile
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileName { get; set; }
        public string Directory { get; set; }
        public string Description { get; set; }
        public DateTime LastAccess { get; set; }
        public byte[] Icon { get; set; }
        public bool Deleted { get; set; }
        public ICollection<FileToOverhead> OverheadNode { get; set; }
    }
}

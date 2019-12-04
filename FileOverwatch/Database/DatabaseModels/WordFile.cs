using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Database.DatabaseModels.LinkingTables;

namespace Database.DatabaseModels
{
    public class WordFile
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileName { get; set; }
        public string Directory { get; set; }
        public string Description { get; set; }
        public DateTime LastAccess { get; set; }
        public bool Deleted { get; set; }
        public ICollection<WordToOverhead> OverheadNode { get; set; }
    }
}

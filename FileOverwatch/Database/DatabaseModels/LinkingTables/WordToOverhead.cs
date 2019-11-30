using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class WordToOverhead
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<WordFile> WordFiles { get; set; }
        public ICollection<FileOverhead> FileOverheads { get; set; }
        public bool Deleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("WordToOverhead")]
    public class WordToOverhead
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public WordFile WordFile { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public bool Deleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("FileToOverhead")]
    public class FileToOverhead
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public LinkedFile LinkedFile { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public bool Deleted { get; set; }
    }
}

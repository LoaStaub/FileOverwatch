using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
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

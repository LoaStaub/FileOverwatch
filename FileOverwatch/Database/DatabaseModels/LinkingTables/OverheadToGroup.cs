using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("OverheadToGroup")]
    public class OverheadToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public Group Group { get; set; }
        public bool Deleted { get; set; }
    }
}

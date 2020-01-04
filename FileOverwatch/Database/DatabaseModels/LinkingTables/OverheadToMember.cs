using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("OverheadToMember")]
    public class OverheadToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public Member Member { get; set; }
        [ForeignKey("FileOverhead")]
        public int FileOverheadId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public bool Deleted { get; set; }
    }
}

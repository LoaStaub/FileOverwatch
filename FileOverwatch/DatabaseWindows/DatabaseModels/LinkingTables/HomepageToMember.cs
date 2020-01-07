using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("HomepageToMember")]
    public class HomepageToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Homepage Homepage { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Homepage")]
        public int HomepageId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public bool Deleted { get; set; }
    }
}

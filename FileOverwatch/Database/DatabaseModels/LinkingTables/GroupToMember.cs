using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("GroupToMember")]
    public class GroupToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Group Group { get; set; }
        public Member Member { get; set; }
        public int GroupId { get; set; }
        public int MemberId { get; set; }
        public bool Deleted { get; set; }
    }
}

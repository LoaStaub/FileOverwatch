using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("EmailToMember")]
    public class EmailToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Email Email { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Email")]
        public int EmailId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public bool Deleted { get; set; }
    }
}

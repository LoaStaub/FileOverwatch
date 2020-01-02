using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("PhoneToMember")]
    public class PhoneToMember
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Member Member { get; set; }
        [ForeignKey("PhoneNumber")]
        public int PhoneNumberId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public bool Deleted { get; set; }
    }
}

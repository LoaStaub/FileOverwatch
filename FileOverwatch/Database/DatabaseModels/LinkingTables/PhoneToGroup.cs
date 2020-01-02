using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("PhoneToGroup")]
    public class PhoneToGroup
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        [ForeignKey("PhoneNumber")]
        public int PhoneNumberId { get; set; }
        public bool Deleted { get; set; }
    }
}

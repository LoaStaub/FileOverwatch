using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("PhoneToOrganization")]
    public class PhoneToOrganization
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Organization Organization { get; set; }
        [ForeignKey("PhoneNumber")]
        public int PhoneNumberId { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public bool Deleted { get; set; }
    }
}

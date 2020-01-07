using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("GroupToOrganization")]
    public class GroupToOrganization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Group Group { get; set; }
        public Organization Organization { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public bool Deleted { get; set; }
    }
}

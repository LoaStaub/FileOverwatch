using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("GroupToOrganizations")]
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

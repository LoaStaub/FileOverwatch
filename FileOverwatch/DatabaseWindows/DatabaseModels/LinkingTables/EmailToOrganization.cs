using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("EmailToOrganization")]
    public class EmailToOrganization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Email Email { get; set; }
        public Organization Organization { get; set; }
        [ForeignKey("Email")]
        public int EmailId { get; set; }
        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }
        public bool Deleted { get; set; }
    }
}

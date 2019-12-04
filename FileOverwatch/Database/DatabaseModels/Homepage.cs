using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Database.DatabaseModels.LinkingTables;

namespace Database.DatabaseModels
{
    public class Homepage
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public ICollection<HomepageToEmployee> EmployeeNode { get; set; }
        public ICollection<HomepageToGroup> GroupNode { get; set; }
        public ICollection<HomepageToOrganization> OrganizationNode { get; set; }
    }
}

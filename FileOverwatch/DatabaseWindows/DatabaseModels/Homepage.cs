using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class Homepage
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public ICollection<HomepageToMember> MemberNode { get; set; }
        public ICollection<HomepageToGroup> GroupNode { get; set; }
        public ICollection<HomepageToOrganization> OrganizationNode { get; set; }
    }
}

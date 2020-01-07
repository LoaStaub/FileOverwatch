using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public bool Deleted { get; set; }
        public ICollection<EmailToGroup> EmailNode { get; set; }
        public ICollection<HomepageToGroup> HomepageNode { get; set; }
        public ICollection<GroupToMember> MemberNode { get; set; }
        public ICollection<GroupToOrganization> OrganizationNode { get; set; }
        public ICollection<PhoneToGroup> PhoneNode { get; set; }
        public ICollection<OverheadToGroup> OverheadNode { get; set; }
    }
}

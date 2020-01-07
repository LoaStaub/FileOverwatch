using System;
using System.Collections.Generic;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class FileOverhead
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Icon { get; set; }
        public bool Deleted { get; set; }
        public ICollection<FileToOverhead> FileNode { get; set; }
        public ICollection<OverheadToMember> MemberNode { get; set; }
        public ICollection<OverheadToOrganization> OrganizationNode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using DatabaseStandard.DatabaseModels.LinkingTables;

namespace DatabaseStandard.DatabaseModels
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CountryFlag { get; set; }
        public string PhoneNr { get; set; }
        public string Description { get; set; }
        public ICollection<PhoneToGroup> GroupNode { get; set; }
        public ICollection<PhoneToMember> MemberNode { get; set; }
        public ICollection<PhoneToOrganization> OrganizationNode { get; set; }
    }
}

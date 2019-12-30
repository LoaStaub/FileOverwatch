using System;

namespace DatabaseStandard.DatabaseModels.LinkingTables
{
    public class PhoneToOrganization
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Organization Organization { get; set; }
        public bool Deleted { get; set; }
    }
}

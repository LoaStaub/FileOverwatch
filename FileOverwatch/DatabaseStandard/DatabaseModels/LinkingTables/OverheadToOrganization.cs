using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseStandard.DatabaseModels.LinkingTables
{
    public class OverheadToOrganization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public FileOverhead FileOverhead { get; set; }
        public Organization Organization { get; set; }
        public bool Deleted { get; set; }
    }
}

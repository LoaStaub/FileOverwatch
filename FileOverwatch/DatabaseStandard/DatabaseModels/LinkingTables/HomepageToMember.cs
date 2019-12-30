using System;
using System.ComponentModel.DataAnnotations;

namespace DatabaseStandard.DatabaseModels.LinkingTables
{
    public class HomepageToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Homepage Homepage { get; set; }
        public Member Member { get; set; }
        public bool Deleted { get; set; }
    }
}

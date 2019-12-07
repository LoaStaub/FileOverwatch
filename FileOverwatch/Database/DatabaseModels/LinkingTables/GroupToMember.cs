using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class GroupToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Group Group { get; set; }
        public Member Member { get; set; }
        public bool Deleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    public class EmailToMember
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Email Email { get; set; }
        public Member Member { get; set; }
        public bool Deleted { get; set; }
    }
}

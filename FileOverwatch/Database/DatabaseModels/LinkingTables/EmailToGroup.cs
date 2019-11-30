using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class EmailToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Group> Groups { get; set; }
        public bool Deleted { get; set; }
    }
}

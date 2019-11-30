using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class EmailToOrganization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<Email> Emails { get; set; }
        public ICollection<Organization> Organizations { get; set; }
        public bool Deleted { get; set; }
    }
}

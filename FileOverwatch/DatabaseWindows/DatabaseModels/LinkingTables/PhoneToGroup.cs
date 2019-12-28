using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    public class PhoneToGroup
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Group Group { get; set; }
        public bool Deleted { get; set; }
    }
}

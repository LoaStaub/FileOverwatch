using System;
using System.Collections.Generic;
using System.Text;
using Database.DatabaseModels.LinkingTables;

namespace Database.DatabaseModels
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string CountryFlag { get; set; }
        public string PhoneNr { get; set; }
        public string Description { get; set; }
    }
}

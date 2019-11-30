using System;
using System.Collections.Generic;
using System.Text;

namespace Database.DatabaseModels
{
    public class FileOverhead
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte Icon { get; set; }
        public bool Deleted { get; set; }
    }
}

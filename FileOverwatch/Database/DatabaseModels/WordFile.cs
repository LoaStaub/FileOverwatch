using System;
using System.Collections.Generic;
using System.Text;

namespace Database.DatabaseModels
{
    public class WordFile
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Directory { get; set; }
        public DateTime LastOpened { get; set; }
        public bool Deleted { get; set; }
    }
}

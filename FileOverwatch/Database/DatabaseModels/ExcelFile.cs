using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels
{
    public class ExcelFile
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FileName { get; set; }
        public string Directory { get; set; }
        public string Description { get; set; }
        public DateTime LastAccess { get; set; }
    }
}

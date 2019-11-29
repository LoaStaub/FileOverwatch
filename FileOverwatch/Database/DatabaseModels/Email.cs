using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    }
}

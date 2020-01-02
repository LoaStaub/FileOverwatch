﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("EmailToOrganization")]
    public class EmailToOrganization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Email Email { get; set; }
        public Organization Organization { get; set; }
        public bool Deleted { get; set; }
    }
}

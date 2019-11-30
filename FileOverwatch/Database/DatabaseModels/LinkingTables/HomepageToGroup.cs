﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class HomepageToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<Homepage> Homepages { get; set; }
        public ICollection<Group> Groups { get; set; }
        public bool Deleted { get; set; }
    }
}
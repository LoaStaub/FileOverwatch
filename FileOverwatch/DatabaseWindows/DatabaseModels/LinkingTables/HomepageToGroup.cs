﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    public class HomepageToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Homepage Homepage { get; set; }
        public Group Group { get; set; }
        public bool Deleted { get; set; }
    }
}

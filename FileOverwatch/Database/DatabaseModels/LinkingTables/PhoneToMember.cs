﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class PhoneToMember
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Member Member { get; set; }
        public bool Deleted { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class Email
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public ICollection<EmailToMember> MemberNode { get; set; }
        public ICollection<EmailToGroup> GroupNode { get; set; }
        public ICollection<EmailToOrganization> OrganizationNode { get; set; }
    }
}

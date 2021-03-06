﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Founded { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public byte[] Picture { get; set; }
        public bool Deleted { get; set; }
        public ICollection<OverheadToOrganization> OverheadNode { get; set; }
        public ICollection<EmailToOrganization> EmailNode { get; set; }
        public ICollection<HomepageToOrganization> HomepageNode { get; set; }
        public ICollection<GroupToOrganization> GroupNode { get; set; }
        public ICollection<PhoneToOrganization> PhoneNode { get; set; }
    }
}

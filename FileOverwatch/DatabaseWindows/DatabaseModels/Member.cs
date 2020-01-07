using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DatabaseWindows.DatabaseModels.LinkingTables;

namespace DatabaseWindows.DatabaseModels
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Description { get; set; }
        public DateTime MemberDate { get; set; }
        public byte[] Picture { get; set; }
        public bool Deleted { get; set; }
        public ICollection<EmailToMember> EmailNode { get; set; }
        public ICollection<HomepageToMember> HomepageNode { get; set; }
        public ICollection<OverheadToMember> OverheadNode { get; set; }
        public ICollection<GroupToMember> GroupNode { get; set; }
        public ICollection<PhoneToMember> PhoneNode { get; set; }
    }
}

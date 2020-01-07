using System;
using DatabaseWindows.DatabaseModels;

namespace ExecutableWindows.Models
{
    class MemberWithGroup
    {
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
        public string GroupName { get; set; }
        public Group Group { get; set; }
        public Member Member { get; set; }
    }
}

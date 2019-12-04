using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Database.DatabaseModels.LinkingTables;

namespace Database.DatabaseModels
{
    public class Employee
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
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public ICollection<EmailToEmployee> EmailNode { get; set; }
        public ICollection<HomepageToEmployee> HomepageNode { get; set; }
        public ICollection<OverheadToEmployee> OverheadNode { get; set; }
        public ICollection<GroupToEmployee> GroupNode { get; set; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Database.DatabaseModels.LinkingTables;

namespace Database.DatabaseModels
{
    public class Group : IEnumerable
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<EmailToGroup> EmailNode { get; set; }
        public ICollection<HomepageToGroup> HomepageNode { get; set; }
        public ICollection<GroupToEmployee> EmployeeNode { get; set; }
        public ICollection<GroupToOrganization> OrganizationNode { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

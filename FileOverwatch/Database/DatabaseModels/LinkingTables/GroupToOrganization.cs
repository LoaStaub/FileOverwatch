using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.DatabaseModels.LinkingTables
{
    public class GroupToOrganization : IEnumerable
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Group Group { get; set; }
        public Organization Organization { get; set; }
        public bool Deleted { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseWindows.DatabaseModels.LinkingTables
{
    [Table("EmailToGroup")]
    public class EmailToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Email Email { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Email")]
        public int EmailId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public bool Deleted { get; set; }
    }
}

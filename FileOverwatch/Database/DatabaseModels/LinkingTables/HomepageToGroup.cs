using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.DatabaseModels.LinkingTables
{
    [Table("HomepageToGroup")]
    public class HomepageToGroup
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Homepage Homepage { get; set; }
        public Group Group { get; set; }
        [ForeignKey("Homepage")]
        public int HomepageId { get; set; }
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public bool Deleted { get; set; }
    }
}

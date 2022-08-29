using BA_Project.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BA_Project.DAL.Entities
{
    public class Record : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ID { get; set; }
        public string RecordName { get; set; }
        public string URL { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public virtual User User { get; set; }
    }
}
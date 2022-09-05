using BA_Project.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BA_Project.DAL.Entities
{
    public class AppSetting : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ID { get; set; }
        public string Key { get; set; }
        public string? Value { get; set; }
    }
}

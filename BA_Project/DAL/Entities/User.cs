using BA_Project.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BA_Project.DAL.Entities
{
    public class User : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public virtual List<Record> Records { get; set; }
        public virtual UserSettings Settings { get; set; }

        public User()
        {
            if(Settings == null)
            {
                Settings = new UserSettings()
                {
                    User = this,
                    UserID = ID,
                    AccountRecoveryCode = GenericFunctions.GeneratePassword(GenericFunctions.PasswordGeneratingOptions.CharactersAndNumbers, 24)
                };
            }
        }
    }
}
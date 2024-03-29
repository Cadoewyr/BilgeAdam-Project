﻿using BA_Project.DAL.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BA_Project.DAL.Entities
{
    public class UserSettings : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        public int ID { get; set; }
        [NotMapped]
        public int UserID { get; set; }
        public User User { get; set; }
        public string AccountRecoveryCode { get; set; }
    }
}
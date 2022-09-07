using BA_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BA_Project.DAL.Context
{
    class DB : DbContext
    {
        DB()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source=keyvault.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(u => u.Settings).WithOne(us => us.User).HasForeignKey<UserSettings>(us => us.UserID);
        }

        public void CloseConnection()
        {
            Database.CloseConnection();
        }

        static DB _instance;
        public static DB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DB();

                return _instance;
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSettings> Settings { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
    }
}
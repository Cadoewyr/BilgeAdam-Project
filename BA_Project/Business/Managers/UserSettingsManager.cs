using BA_Project.Business.Interfaces;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace BA_Project.Business.Managers
{
    public class UserSettingsManager : IManager<UserSettings>
    {
        public void Add(UserSettings entity)
        {
            if (DB.Instance.Settings.Where(x => x.User.ID == entity.User.ID).FirstOrDefault() == null)
            {
                DB.Instance.Settings.Add(entity);
                DB.Instance.SaveChanges();
            }
            else
                throw new Exception("There is already exists a record for this user.");
        }

        public bool Exists(Expression<Func<UserSettings, bool>> predicate)
        {
            return DB.Instance.Settings.Any(predicate);
        }

        public List<UserSettings> Get(Expression<Func<UserSettings, bool>> predicate)
        {
            return DB.Instance.Settings.Where(predicate).ToList();
        }

        public List<UserSettings> GetAll()
        {
            return DB.Instance.Settings.ToList();
        }

        public void Remove(UserSettings entity)
        {
            DB.Instance.Settings.Remove(entity);
        }

        public void Update(UserSettings oldEntity, UserSettings newEntity)
        {
            var temp = DB.Instance.Settings.Find(oldEntity.ID);

            if (temp != null)
            {
                temp.RememberMe = newEntity.RememberMe;
                DB.Instance.SaveChanges();
            }
            else
                throw new NullReferenceException("There is no any setting record.");
        }
    }
}

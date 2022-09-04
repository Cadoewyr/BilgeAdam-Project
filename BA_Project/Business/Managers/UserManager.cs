using BA_Project.Business.Interfaces;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using BA_Project.Validation;
using System.Linq.Expressions;
using System.Text;

namespace BA_Project.Business.Managers
{
    public class UserManager : IManager<User>
    {
        public void Add(User entity)
        {
            var result = new UserValidator().Validate(entity);

            if (result.IsValid)
            {
                try
                {
                    if (DB.Instance.Users.Where(x => x.Username == entity.Username).FirstOrDefault() == null)
                    {
                        DB.Instance.Users.Add(entity);
                        DB.Instance.SaveChanges();
                    }
                    else
                        throw new Exception("This username already registered.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                StringBuilder SB = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    SB.Append(error.ErrorMessage).AppendLine();
                }

                throw new Exception(SB.ToString());
            }
        }
        public void Update(User oldEntity, User newEntity)
        {
            var result = new UserValidator().Validate(newEntity);

            if (result.IsValid)
            {
                var temp = DB.Instance.Users.Find(oldEntity.ID);

                if (temp != null)
                {
                    temp.Records = newEntity.Records;
                    temp.Settings = newEntity.Settings;
                    temp.Username = newEntity.Username;
                    temp.Password = newEntity.Password;

                    DB.Instance.SaveChanges();
                }
                else
                    throw new NullReferenceException("There is no any record.");
            }
            else
            {
                StringBuilder SB = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    SB.Append(error.ErrorMessage).AppendLine();
                }

                throw new Exception(SB.ToString());
            }
            
        }
        public void Remove(User entity)
        {
            DB.Instance.Users.Remove(entity);
            DB.Instance.SaveChanges();
        }
        public List<User> Get(Expression<Func<User, bool>>? predicate)
        {
            if (predicate != null)
                return DB.Instance.Users.Where(predicate).ToList();
            else
                return DB.Instance.Users.ToList();
        }
        public bool Exists(Expression<Func<User, bool>> predicate)
        {
            return DB.Instance.Users.Any(predicate);
        }
    }
}
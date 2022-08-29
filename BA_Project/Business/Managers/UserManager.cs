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

        public List<User> GetAll()
        {
            return DB.Instance.Users.ToList();
        }

        public User Get(Expression<Func<User, bool>> predicate)
        {
            return DB.Instance.Users.Where(predicate).FirstOrDefault();
        }

        public void Remove(User entity)
        {
            DB.Instance.Users.Remove(entity);
            DB.Instance.SaveChanges();
        }

        public void Update(User entity)
        {
            var temp = DB.Instance.Users.Find(entity.ID);

            if (temp != null)
            {
                temp = entity;
                DB.Instance.SaveChanges();
            }
            else
                throw new NullReferenceException("There is no any user record.");
        }

        public bool Exists(Expression<Func<User, bool>> predicate)
        {
            return DB.Instance.Users.Any(predicate);
        }
    }
}
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
            entity.Username = entity.Username.Trim();

            var result = new UserValidator().Validate(entity);

            if (result.IsValid)
            {
                try
                {
                    if (!DB.Instance.Users.Any(x => x.Username == entity.Username))
                    {
                        DB.Instance.Users.Add(entity);
                        DB.Instance.SaveChanges();
                    }
                    else
                        throw new Exception("This username already registered.");
                }
                catch (Exception ex)
                {
                    throw ex;
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
        public void Update(User entity, string? username, string? password, string? email)
        {
            User temp = new User()
            {
                Username = username == null ? entity.Username.Trim() + DateTime.Now.ToLongTimeString() : username,
                Password = password == null ? entity.Password : password,
                EMail = email == null ? entity.EMail : email
            };

            var result = new UserValidator().Validate(temp);

            if (result.IsValid)
            {
                User user = DB.Instance.Users.Find(entity.ID);

                if (user != null)
                {
                    user.Username = (username == null ? entity.Username : username).Trim();
                    user.Password = password == null ? temp.Password : Cryptography.MD5.Encrypt(password);
                    user.EMail = temp.EMail;
                }
                else
                    throw new Exception("User doesnt exists.");

                DB.Instance.SaveChanges();
            }
            else
            {
                StringBuilder sb = new StringBuilder();

                foreach (var error in result.Errors)
                {
                    sb.Append(error.ErrorMessage).AppendLine();
                }

                throw new Exception(sb.ToString());
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
using BA_Project.Business.Interfaces;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using BA_Project.Validation;
using System.Linq.Expressions;
using System.Text;

namespace BA_Project.Business.Managers
{
    public class AppSettingManager : IManager<AppSetting>
    {
        public void Add(AppSetting entity)
        {
            var result = new AppSettingValidator().Validate(entity);

            if (result.IsValid)
            {
                try
                {
                    DB.Instance.AppSettings.Add(entity);
                    DB.Instance.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                
                foreach(var error in result.Errors)
                {
                    sb.Append(error).AppendLine();
                }

                throw new Exception(sb.ToString());
            }
        }

        public void Update(AppSetting entity, string value)
        {
            DB.Instance.AppSettings.Find(entity.ID).Value = value;
            DB.Instance.SaveChanges();
        }

        public bool Exists(Expression<Func<AppSetting, bool>> predicate)
        {
            return DB.Instance.AppSettings.Any(predicate);
        }

        public List<AppSetting> Get(Expression<Func<AppSetting, bool>> predicate)
        {
            return DB.Instance.AppSettings.Where(predicate).ToList();
        }

        public void Remove(AppSetting entity)
        {
            DB.Instance.AppSettings.Remove(entity);
            DB.Instance.SaveChanges();
        }
    }
}

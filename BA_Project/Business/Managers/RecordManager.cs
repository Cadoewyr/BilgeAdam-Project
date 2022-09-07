using BA_Project.Business.Interfaces;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using BA_Project.Validation;
using System.Linq.Expressions;
using System.Text;

namespace BA_Project.Business.Managers
{
    public class RecordManager : IManager<Record>
    {
        public void Add(Record entity)
        {
            entity.RecordName = entity.RecordName.Trim();
            entity.EMail = entity.EMail.Trim();
            entity.URL = entity.URL.Trim();
            entity.Username = entity.Username.Trim();
            entity.Password = entity.Password;

            var result = new RecordValidator().Validate(entity);

            if (result.IsValid)
            {
                DB.Instance.Records.Add(entity);
                DB.Instance.SaveChanges();
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
        public void Update(Record entity, string? recordName, string? email, string? username, string? url, string? password)
        {
            Record temp = new Record()
            {
                RecordName = (recordName == null ? entity.RecordName : recordName).Trim(),
                EMail = (email == null ? entity.EMail : email).Trim(),
                URL = (url == null ? entity.URL : url).Trim(),
                Username = (username == null ? entity.Username : username).Trim(),
                Password = password == null ? entity.Password : password
            };

            var result = new RecordValidator().Validate(temp);

            if (result.IsValid)
            {
                var rec = DB.Instance.Records.Find(entity.ID);

                if (rec != null)
                {
                    rec.RecordName = temp.RecordName;
                    rec.URL = temp.URL;
                    rec.EMail = temp.EMail;
                    rec.Username = temp.Username;
                    rec.Password = temp.Password;

                    DB.Instance.SaveChanges();
                }
                else
                    throw new NullReferenceException("Record doesnt exists.");
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
        public void Remove(Record entity)
        {
            DB.Instance.Records.Remove(entity);
            DB.Instance.SaveChanges();
        }
        public void Remove(Expression<Func<Record, bool>> predicate)
        {
            DB.Instance.Records.RemoveRange(DB.Instance.Records.Where(predicate));
            DB.Instance.SaveChanges();
        }
        public List<Record> Get(Expression<Func<Record, bool>>? predicate)
        {
            if (predicate != null)
                return DB.Instance.Records.Where(predicate).ToList();
            else
                return DB.Instance.Records.ToList();
        }
        public bool Exists(Expression<Func<Record, bool>> predicate)
        {
            return DB.Instance.Records.Any(predicate);
        }
    }
}

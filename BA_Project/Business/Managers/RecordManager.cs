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
        public void Update(Record oldEntity, Record newEntity)
        {
            var result = new RecordValidator().Validate(newEntity);

            if (result.IsValid)
            {
                var temp = DB.Instance.Records.Find(oldEntity.ID);

                if (temp != null)
                {
                    temp.RecordName = newEntity.RecordName;
                    temp.URL = newEntity.URL;
                    temp.Mail = newEntity.Mail;
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
        public void Remove(Record entity)
        {
            DB.Instance.Records.Remove(entity);
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

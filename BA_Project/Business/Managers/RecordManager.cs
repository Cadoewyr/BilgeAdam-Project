using BA_Project.Business.Interfaces;
using BA_Project.DAL.Context;
using BA_Project.DAL.Entities;
using BA_Project.Validation;
using System.Linq;
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

        public List<Record> GetAll()
        {
            return DB.Instance.Records.ToList();
        }

        public Record Get(Expression<Func<Record, bool>> predicate)
        {
            return DB.Instance.Records.Where(predicate).FirstOrDefault();
        }

        public void Remove(Record entity)
        {
            DB.Instance.Records.Remove(entity);
        }

        public void Update(Record entity)
        {
            var temp = DB.Instance.Records.Find(entity.ID);

            if (temp != null)
            {
                temp = entity;
                DB.Instance.SaveChanges();
            }
            else
                throw new NullReferenceException("There is no any account record.");
        }

        public bool Exists(Expression<Func<Record, bool>> predicate)
        {
            return DB.Instance.Records.Any(predicate);
        }
    }
}

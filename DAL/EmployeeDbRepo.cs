using Entity;
using Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    class EmployeeDbRepo : IEmployee<EEmployee>
    {
        EmpDbContext db;
        public EmployeeDbRepo(EmpDbContext _db)
        {
            db = _db;       
        }
        public void Add(EEmployee entity)
        {
            db.Emp.Add(entity);
        }

        public void Delete(int id)
        {
            var e = Find(id);
            db.Emp.Remove(e);
            db.SaveChanges();

        }

        public EEmployee Find(int id)
        {
            var e = db.Emp.Include(a => a.Department).SingleOrDefault(b => b.Id == id);
            return e;
        }

        public IList<EmpByModel> List()
        {
            return db.EBM.ToList();
        }

        public IList<EmpByModel> ListByModel()
        {
            throw new NotImplementedException();
        }

        public List<EEmployee> Search(string term)
        {
            var result = db.Emp.Include(a => a.Department)
                .Where(b => b.FirstName.Contains(term)
                        || b.LastName.Contains(term)
                        || b.Department.Name.Contains(term)).ToList();

            return result;
        }

        public void Update(int id, EEmployee entity)
        {
            db.Update(entity);
            db.SaveChanges();
        }

        IList<EEmployee> IEmployee<EEmployee>.List()
        {
            throw new NotImplementedException();
        }
    }
}

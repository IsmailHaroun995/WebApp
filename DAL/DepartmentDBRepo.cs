using Entity;
using Logic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
     public class DepartmentDBRepo : IEmployee<EDepartment>
    {
        EmpDbContext db;
        public DepartmentDBRepo(EmpDbContext _db)
        {
            db = _db;
        }

        public void Add(EDepartment entity)
        {
            db.Dep.Add(entity);
        }

        public void Delete(int id)
        {
            var d = Find(id);
            db.Dep.Remove(d);
            db.SaveChanges();
        }

        public EDepartment Find(int id)
        {
            var e = db.Dep.Include(a => a.Id).SingleOrDefault(b => b.Id == id);
            return e;
        }

        public IList<EDepartment> List()
        {
            return db.Dep.ToList();
        }

        public IList<EmpByModel> ListByModel()
        {
            throw new NotImplementedException();
        }

        public List<EDepartment> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, EDepartment entity)
        {
            throw new NotImplementedException();
        }
    }
}

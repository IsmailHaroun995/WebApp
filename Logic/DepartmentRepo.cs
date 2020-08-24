using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class DepartmentRepo : IEmployee<EDepartment>
    {
        IList<EDepartment> eDepartments;
        public DepartmentRepo()
        {
            eDepartments = new List<EDepartment>()
                {
                    new EDepartment{Id=1,Name= "Department1" },
                    new EDepartment{Id=1,Name= "Department2" }

                };
        }
        public void Add(EDepartment entity)
        {
            eDepartments.Add(entity);
        }

        public void Delete(int id)
        {
            var d = Find(id);
            eDepartments.Remove(d);
        }

        public EDepartment Find(int id)
        {
            var d = eDepartments.SingleOrDefault(b => b.Id == id);
            return d;
        }

        public IList<EDepartment> List()
        {
            return eDepartments;
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
            var d= Find(id);
            d.Name = entity.Name;

        }
    }
}

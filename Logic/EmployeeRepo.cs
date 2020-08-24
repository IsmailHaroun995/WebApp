using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class EmployeeRepo : IEmployee<EEmployee>
    {
        List<EEmployee> eEmployees;
        public EmployeeRepo()
        {
            eEmployees = new List<EEmployee>
            {
                new EEmployee
                {
                    Id =1,
                    FirstName = "ismail",
                    LastName = "Haroun",
                    Gender = "Male",
                    Address = "Amman",
                    Email = "ismail@test.com",
                    Password = "123"
                }
            };
        }
        public void Add(EEmployee entity)
        {
            eEmployees.Add(entity);
        }

        public void Delete(int id)
        {
            var e = Find(id);
            eEmployees.Remove(e);
        }

        public EEmployee Find(int id)
        {
            var e = eEmployees.SingleOrDefault(b => b.Id == id);
            return e;
        }

        public IList<EEmployee> List()
        {
            return eEmployees;
        }

        public IList<EmpByModel> ListByModel()
        {
            throw new NotImplementedException();
        }

        public List<EEmployee> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, EEmployee entity)
        {
            var e = Find(id);
            e.FirstName = entity.FirstName;
            e.LastName = entity.LastName;
            e.Gender = entity.Gender;
            e.Email = entity.Email;
            e.Address = entity.Address;
            e.Password = entity.Password;
        }

        //IList<EmpByModel> IEmployee<EEmployee>.ListByModel()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

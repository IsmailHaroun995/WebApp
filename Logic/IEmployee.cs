using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public interface IEmployee<Tentity>
    {
        IList<EmpByModel> ListByModel();
        IList<Tentity> List();
        Tentity Find(int id);
        void Add(Tentity entity);
        void Update(int id, Tentity entity);
        void Delete(int id);
        List<Tentity> Search(string term);
    }
}

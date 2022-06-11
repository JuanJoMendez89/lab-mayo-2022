using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class ShippersLogic : IABMLogic<Shippers, int>
    {
        private readonly ShippersData _shippersData;

        public ShippersLogic()
        {
            _shippersData = new ShippersData();
        }

        public void Add(Shippers entity)
        {
            _shippersData.Add(entity);
        }

        public void Delete(int id)
        {
            _shippersData.Delete(id);
        }

        public List<Shippers> GetAll()
        {
            return _shippersData.GetAll();
        }

        public Shippers GetByID(int id)
        {
            return _shippersData.GetByID(id);
        }

        public void Update(Shippers entity)
        {
            _shippersData.Update(entity);
        }
    }
}

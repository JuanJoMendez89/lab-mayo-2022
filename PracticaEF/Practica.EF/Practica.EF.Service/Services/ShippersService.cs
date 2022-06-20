using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using Practica.EF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service.Services
{
    public class ShippersService : IShippersService
    {
        private ShippersLogic _shippersLogic;

        public ShippersService()
        {
            _shippersLogic = new ShippersLogic();
        }

        public void Add(ShippersDTO shippersDto)
        {
            _shippersLogic.Add(shippersDto);
        }

        public void Delete(int id)
        {
            _shippersLogic.Delete(id);
        }

        public List<ShippersDTO> GetAll()
        {
            return _shippersLogic.GetAll();
        }

        public ShippersDTO GetByID(int id)
        {
            return _shippersLogic.GetByID(id);
        }

        public void Update(ShippersDTO shippersDto)
        {
            _shippersLogic.Update(shippersDto);
        }
    }
}

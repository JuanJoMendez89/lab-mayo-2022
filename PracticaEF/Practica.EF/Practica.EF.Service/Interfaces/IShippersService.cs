using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service.Interfaces
{
    public interface IShippersService
    {
        List<ShippersDTO> GetAll();
        ShippersDTO GetByID(int id);
        void Add(ShippersDTO entity);
        void Update(ShippersDTO entity);
        void Delete(int id);
    }

}

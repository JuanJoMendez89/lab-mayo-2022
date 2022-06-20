using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Service.Interfaces
{
    public interface ICustomersService
    {
        List<CustomersDTO> GetAll();
        CustomersDTO GetByID(string id);
        void Add(CustomersDTO entity);
        void Update(CustomersDTO entity);
        void Delete(string id);
    }
}

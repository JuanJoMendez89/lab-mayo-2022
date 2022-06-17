using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Mappers
{
    public class ShippersMapper
    {
        public ShippersDTO CreateDTO(Shippers shippers) {
            return new ShippersDTO
            {
                ShipperID = shippers.ShipperID,
                CompanyName = shippers.CompanyName,
                Phone = shippers.Phone
            };
        }

        public Shippers ShippersDTOToShippers(ShippersDTO shippersDTO)
        {
            return new Shippers
            {
                ShipperID = shippersDTO.ShipperID,
                CompanyName = shippersDTO.CompanyName,
                Phone = shippersDTO.Phone
            };
        }
    }
}

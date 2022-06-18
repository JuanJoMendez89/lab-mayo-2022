using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Extensions
{
    public static class ShippersExtensions
    {
        public static ShippersDTO CreateDTO(this Shippers shippers)
        {
            return new ShippersMapper().CreateDTO(shippers);
        }

        public static Shippers ReverseMap(this ShippersDTO shippersDTO)
        {
            return new ShippersMapper().ShippersDTOToShippers(shippersDTO);
        }
    }
}

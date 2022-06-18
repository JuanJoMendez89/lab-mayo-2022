using Practica.EF.Data.Data;
using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Interfaces;
using Practica.EF.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Practica.EF.Common.Exceptions;

namespace Practica.EF.Logic.Logic
{
    public class ShippersLogic : BaseLogic, ICRUDLogic<ShippersDTO, int>
    {
        private ShippersData _shippersData;

        public ShippersLogic()
        {
            _shippersData = new ShippersData();
        }

        public void Add(ShippersDTO shippersDTO)
        {
            try
            {
                Shippers shipper = shippersDTO.ReverseMap(); ;

                ValidateShipper(shipper);

                _shippersData.Add(shipper);
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }

        public void Delete(int id)
        {
            try
            {
                _shippersData.Delete(id);

            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        public List<ShippersDTO> GetAll()
        {
            try
            {
                List<Shippers> shippers = _shippersData.GetAll();

                return shippers.Select(c => c.CreateDTO()).ToList();
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }
        }

        public ShippersDTO GetByID(int id)
        {
            try
            {
                return _shippersData.GetByID(Convert.ToInt32(id)).CreateDTO();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }
        }

        public void Update(ShippersDTO shippersDTO)
        {
            try
            {
                Shippers shipper = shippersDTO.ReverseMap();

                ValidateShipper(shipper);

                _shippersData.Update(shipper);
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        private void ValidateShipper(Shippers Shipper)
        {
            if (String.IsNullOrEmpty(Shipper.CompanyName))
                throw new InvalidFieldException("Field value is empty or invalid", "CompanyName");
        }

    }
}

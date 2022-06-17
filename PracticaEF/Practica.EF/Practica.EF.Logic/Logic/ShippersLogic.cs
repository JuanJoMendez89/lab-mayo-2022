using Practica.EF.Data.Data;
using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Interfaces;
using Practica.EF.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

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
                _shippersData.Add(shippersDTO.MapToShippers());
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
                _shippersData.Update(shippersDTO.MapToShippers());
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

    }
}

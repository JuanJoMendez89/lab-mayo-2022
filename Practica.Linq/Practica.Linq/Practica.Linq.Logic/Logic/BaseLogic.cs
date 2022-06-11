﻿using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public abstract class BaseLogic<T>
    {
        protected DataTable ConvertirListaATabla(List<T> list)
        {
            DataTable dataTable = new DataTable();
            PropertyInfo[] properties = (typeof(T)).GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in list)
            {
                var itemValues = new object[properties.Length];

                for (int i = 0; i < properties.Length; i++)
                {

                    itemValues[i] = properties[i].GetValue(item, null);
                }

                dataTable.Rows.Add(itemValues);
            }

            return dataTable;
        }

        protected DataTable ConvertirEntidadATabla(T entity)
        {
            DataTable dataTable = new DataTable();
            PropertyInfo[] properties = (typeof(T)).GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                dataTable.Columns.Add(prop.Name);
            }

            var itemValues = new object[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                object value = properties[i].GetValue(entity);

                if (value.GetType() == typeof(BaseEntity)){
                    itemValues[i] = properties[i].GetValue(entity);
                }

                itemValues[i] = properties[i].GetValue(entity);
            }

            dataTable.Rows.Add(itemValues);

            return dataTable;
        }
    }
}

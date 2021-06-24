﻿using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositoryTaxi
    {
        private SqlConnection _connection;

        public RepositoryTaxi(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public void GuardarTaxi(Taxi taxi)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO TAXIS (Placa, Modelo, Kilometraje)" +
                    "Values (@Placa,@Modelo,@Kilometraje)";
                command.Parameters.Add("@Placa", SqlDbType.VarChar).Value = taxi.Placa;
                command.Parameters.Add("@Modelo", SqlDbType.Decimal).Value = taxi.Modelo;
                command.Parameters.Add("@Kilometraje", SqlDbType.Decimal).Value = taxi.Kilometraje;

                command.ExecuteNonQuery();

            }
        }
    }
}

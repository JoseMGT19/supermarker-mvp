﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;

namespace Supermarket_mvp._Repositories
{
    internal class ProviderRepository : BaseRepository, IProviderRepository
    {
        public ProviderRepository(string connectionString)
        { 
            this.connectionString = connectionString;
        }
        public void Add(ProvidersModel providerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Providers VALUES(@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providerModel.Observation;

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Providers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(ProvidersModel providerModel)
        {
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Providers 
                                            SET Providers_Name = @name,
                                            Providers_Observation = @observation
                                            WHERE Providers_Id = @id";
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerModel.Name;
                    command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = providerModel.Observation;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = providerModel.Id;
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<ProvidersModel> GetAll()
        {
            var providerList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Providers_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.Id = (int)reader["Providers_Id"];
                        providerModel.Name = reader["Providers_Name"].ToString();
                        providerModel.Observation = reader["Providers_Observation"].ToString();
                        providerList.Add(providerModel);

                    }
                }
            }
            return providerList;
        }

        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providerList = new List<ProvidersModel>();
            int providerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers WHERE Providers_Id=@id or Providers_Name LIKE @name+ '%' ORDER By Providers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providerModel = new ProvidersModel();
                        providerModel.Id = (int)reader["Providers_Id"];
                        providerModel.Name = reader["Providers_Name"].ToString();
                        providerModel.Observation = reader["Providers_Observation"].ToString();
                        providerList.Add(providerModel);

                    }
                }
            }
            return providerList;
        }
    }
}

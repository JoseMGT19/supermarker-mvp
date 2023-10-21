using System;
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
    internal class CategorieRepository : BaseRepository, ICategorieRepository
    {
        public CategorieRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel categorieMode)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategoriesModel categorieMode)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categorieList = new List<CategoriesModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories ORDER BY Categories_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriesModel();
                        categorieModel.Id = (int)reader["Categories_Id"];
                        categorieModel.Name = reader["Categories_Name"].ToString();
                        categorieModel.Observation = reader["Categories_Observation"].ToString();
                        categorieList.Add(categorieModel);

                    }
                }
            }
            return categorieList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categorieList = new List<CategoriesModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Categories WHERE Categories_Id=@id or Categories_Name LIKE @name+ '%' ORDER By Categories_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriesModel();
                        categorieModel.Id = (int)reader["Categories_Id"];
                        categorieModel.Name = reader["Categories_Name"].ToString();
                        categorieModel.Observation = reader["Categories_Observation"].ToString();
                        categorieList.Add(categorieModel);

                    }
                }
            }
            return categorieList;
        }
    }
}

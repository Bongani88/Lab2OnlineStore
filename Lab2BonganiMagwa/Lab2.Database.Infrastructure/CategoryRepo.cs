using Dapper;
using Lab2.CommonModules.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Database.Infrastructure
{
    internal class CategoryRepo : ICategory
    {
        public Task<bool> Add(ICategory category)
        {
            try
            {
                var sql = "stiInsertCategory";
                var connectionString = "";
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var values = new
                    {
                        category_ID = category.Category_ID,
                        categoryName = category.categoryName,
                        categoryType = category.categoryType
                    }

                    var query = connection.Execute(sql, values, commandType: System.Data.CommandType.StoredProcedure);
                }
            } catch (Exception ex)
            {

            }
            return false;
        }

        public Task<bool> Delete(ICategory category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(ICategory category)
        {
            throw new NotImplementedException();
        }
    }
}

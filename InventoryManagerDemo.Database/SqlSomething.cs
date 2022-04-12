using System;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagerDemo.Database
{
    public class SqlSomething
    {
        public SqlSomething()
        {
        }


        public void DoSomething(string searchValue)
        {
            string connectionString = string.Empty;

            // BAD: the category might have SQL special characters in it
            using (var connection = new SqlConnection(connectionString))
            {
                var query1 = "SELECT ITEM,PRICE FROM PRODUCT WHERE ITEM_CATEGORY='"
                  + searchValue + "' ORDER BY PRICE";
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"{query1}";
                // return result;
            }
        }
    }
}

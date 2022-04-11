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


        public DataSet DoSomething(string searchValue)
        {
            string connectionString = string.Empty;

            // BAD: the category might have SQL special characters in it
            using (var connection = new SqlConnection(connectionString))
            {
                var query1 = "SELECT ITEM,PRICE FROM PRODUCT WHERE ITEM_CATEGORY='"
                  + searchValue + "' ORDER BY PRICE";
                var adapter = new SqlDataAdapter(query1, connection);
                var result = new DataSet();
                adapter.Fill(result);
                return result;
            }
        }
    }
}

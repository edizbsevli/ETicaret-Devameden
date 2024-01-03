using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1
{
    public class SqlConnectionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=EDIZ\\SQLEXPRESS;Initial Catalog=yenieticaret;Integrated Security=True");

        public static void CheckConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
            else
            {

            }
        }
    }
}
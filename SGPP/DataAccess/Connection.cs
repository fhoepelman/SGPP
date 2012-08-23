using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection
    {
        private Connection() 
        { }
      
        //Metodo Singlenton
        private static SqlConnection _connection = null;

        public static SqlConnection Get
        {
            get
         {
             if (_connection == null)
                 _connection = new SqlConnection(@"data source = francis-pc\SQLEXPRESS; integrated security = true; initial catalog = SCP; user id = sa; password = francis3009");
             return _connection;
         }
        }
    }
}

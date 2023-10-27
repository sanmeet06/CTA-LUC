using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLDataLayer
{
    public class MainSQLConnection
    {
        private SqlConnection conn;

        public MainSQLConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=sql.cs.luc.edu;uid=ssingh24;pwd=p35464";
            conn.Open();
        }
    }
}

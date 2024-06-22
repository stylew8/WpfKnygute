using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKnygute.DAL
{
    public class DbHelper
    {
        private const string ConnString = "";
        private static SqlConnection _connection;

        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                _connection = new SqlConnection(ConnString);
            }

            return _connection;
        }

    }
}

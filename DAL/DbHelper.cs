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
        private const string ConnString = "Data Source=SQL6031.site4now.net;Initial Catalog=db_aa5307_artursobol666;User Id=db_aa5307_artursobol666_admin;Password=artursobol666";
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

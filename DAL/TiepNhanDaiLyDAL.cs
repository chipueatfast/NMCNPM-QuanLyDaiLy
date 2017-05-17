using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{

    public class TiepNhanDaiLyDAL
    {

        private DbConnection _connection;

        /// <Property>
        /// GET and SET convention
        /// </Property>
        /// 
        public DbConnection Connection
        {
            get
            {
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }
        public TiepNhanDaiLyDAL()
        {
            _connection = new DbConnection();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace DAL
{

    public class DbConnection
    {
        private SqlDataAdapter _dataAdapter;
        private SqlConnection _connection;
        ///<constructor>
        ///Initialise Connection
        ///</constructor>

        public DbConnection()
        {
            //string connectionString = "C:\\Users\\Gnar\\Desktop\\Software\\FinalHandIn\\3-Layer-Architecture\\DAO\\AdidasOutlet.mdf";
            _dataAdapter = new SqlDataAdapter();
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.QuanLyDaiLyConnectionString1"].ConnectionString);
        }
        ///<method>
        ///Open A Database if Closed or Broken
        ///</method>

        private SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed || _connection.State == ConnectionState.Broken)
            {
                _connection.Open();

            }
            return _connection;
        }
        ///<method>
        ///Select Querry
        ///</method>

        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                _dataAdapter.SelectCommand = myCommand;
                _dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (Exception e)
            {
                Console.Write("Exception query:" + _query + "\n" + e.StackTrace.ToString());
            }
            finally
            {

            };
            return dataTable;
        }
        ///<method>
        ///Insert Query
        ///</method>

        public bool executeInsertQuery(string _query, SqlParameter[] sqlParam)
        {
            var myCommand = new SqlCommand();
            try
            {
                myCommand.CommandText = _query;
                myCommand.Connection = OpenConnection();
                myCommand.Parameters.AddRange(sqlParam);
                _dataAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.Write("Exception query:" + _query + "\n" + e.StackTrace.ToString());
            };

            return true;
        }
        ///<method>
        ///Delete Query
        ///</method>

        public bool executeDeleteQuery(String _query, SqlParameter[] sqlParam)
        {
            var myCommand = new SqlCommand();
            try
            {
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParam);
                myCommand.Connection = OpenConnection();
                _dataAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write("Exception query:" + _query + "\n" + e.StackTrace.ToString());
            }
            finally
            {

            };
            return true;
        }


        ///<method>
        ///Update Query
        ///</method>

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParam)
        {
            var myCommand = new SqlCommand();
            try
            {
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParam);
                myCommand.Connection = OpenConnection();
                _dataAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write("Exception query:" + _query + "\n" + e.StackTrace.ToString());
            }
            finally
            {

            };
            return true;

        }

    }

}

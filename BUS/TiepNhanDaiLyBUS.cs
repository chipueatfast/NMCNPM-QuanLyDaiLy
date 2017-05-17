using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace BUS
{
    public class TiepNhanDaiLyBUS
    {
        DAL.TiepNhanDaiLyDAL userDAL;
        public TiepNhanDaiLyBUS()
        {
            userDAL = new DAL.TiepNhanDaiLyDAL();
        }
        ///<method>
        /// Lấy thông tin cho các ComboBox
        /// </method>
        public DataTable FillComboBox(string tableName, string columnName)
        {
            string query = "SELECT @columnName from @tableName";
            List<SqlParameter> sqlParam = new List<SqlParameter>();
            sqlParam.Add(new SqlParameter("@columnName", columnName));
            sqlParam.Add(new SqlParameter("@tableName", tableName));
            return userDAL.Connection.executeSelectQuery(query, sqlParam.ToArray());

        }
        
        /// <method>
        /// Tiến hành Tiếp nhận Đại lý và bổ sung những trường còn thiếu
        /// </method>
        
        public int Insert(DTO.DaiLyVO input)
        {


            var sqlParam = new List<SqlParameter>();
            sqlParam.Add(new SqlParameter("@ten", input.TenDaiLy));
            sqlParam.Add(new SqlParameter("@madl", input.MaLoaiDaiLy));
            sqlParam.Add(new SqlParameter("@dt", input.DienThoai));
            sqlParam.Add(new SqlParameter("@dc", input.DiaChi));
            sqlParam.Add(new SqlParameter("@mq", input.MaQuan));
            sqlParam.Add(new SqlParameter("@em", input.Email));
            sqlParam.Add(new SqlParameter("@ntq", input.NgayTiepQuan));


            string query = "INSERT into [DAILY] VALUES(@ten, @madl, @dt, @dc, @mq, @ntq, @em)";

            if (userDAL.Connection.executeInsertQuery(query, sqlParam.ToArray()) == true)
                return 1;
            else return 0;


        }
    }
}

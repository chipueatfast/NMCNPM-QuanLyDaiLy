using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DaiLyVO
    {
        string _tenDaiLy;
        int _maLoaiDaiLy;
        string _dienThoai;
        string _diaChi;
        int _maQuan;
        DateTime _ngayTiepQuan;
        string _email;
        ///<constructor>
        ///Construct a DaiLy Object with param
        ///</constructor>

        public DaiLyVO(string tenDaiLy, int maLoaiDaiLy, int maQuan, string dienThoai = "None", string email = "None", string diaChi = "None", DateTime? ngayTiepQuan = null)
        {
            if (!ngayTiepQuan.HasValue)
            {
                ngayTiepQuan = DateTime.Now;
            }
            _tenDaiLy = tenDaiLy;
            _maLoaiDaiLy = maLoaiDaiLy;
            _dienThoai = dienThoai;
            _diaChi = diaChi;
            _maQuan = maQuan;
            _email = email;
        }

        ///<properties>
        /// GET and SET convention
        ///</properties>

        public string TenDaiLy
        {
            get
            {
                return _tenDaiLy;
            }
            set
            {
                _tenDaiLy = value;
            }
        }
        public int MaLoaiDaiLy
        {
            get
            {
                return _maLoaiDaiLy;
            }
            set
            {
                _maLoaiDaiLy = value;
            }
        }
        public string DienThoai
        {
            get
            {
                return _dienThoai;
            }
            set
            {
                _dienThoai = value;
            }
        }
        public string DiaChi
        {
            get
            {
                return _diaChi;
            }
            set
            {
                _diaChi = value;
            }
        }
        public int MaQuan
        {
            get
            {
                return _maQuan;
            }
            set
            {
                _maQuan = value;
            }
        }
        public DateTime NgayTiepQuan
        {
            get
            {
                return _ngayTiepQuan;
            }
            set
            {
                _ngayTiepQuan = value;

            }
        }
        public string Email
        {
            get
            {
                return _email;

            }
            set
            {
                _email = value;
            }
        }

    }
}

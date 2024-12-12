using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taiKhoanDAL;
        public TaiKhoanBLL()
        {
            taiKhoanDAL = new TaiKhoanDAL();
        }

        public bool ChangePassword(string maTK, string oldPassword, string newPassword)
        {
            // Validate mã tài khoản
            if (string.IsNullOrWhiteSpace(maTK))
            {
                return false;
            }

            // Validate mật khẩu
            if (oldPassword == newPassword)
            {
                return false;
            }

            // Kiểm tra độ dài mật khẩu
            if (newPassword.Length < 6)
            {
                return false;
            }

            return taiKhoanDAL.ChangePassword(maTK, newPassword);
        }
    }
}

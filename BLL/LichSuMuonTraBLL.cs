using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LichSuMuonTraBLL
    {
        private LichSuMuonTraDAL lichSuMuonTraDAL;

        public LichSuMuonTraBLL(string connectionString)
        {
            lichSuMuonTraDAL = new LichSuMuonTraDAL(connectionString);
        }

        public List<LichSuMuonTraDTO> LayLichSuMuonTraTheoDocGia(string maDocGia)
        {
            return lichSuMuonTraDAL.LayLichSuMuonTraTheoDocGia(maDocGia);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace checkUpdate
{
    class ketnoi
    {
        #region Khoi tao ketnoi
        private MySqlConnection conn = null;
        private ketnoi(string host)
        {
            string connstring = string.Format("Server=" + host + ";port=3306; database=cnf; User Id=hts; password=hoanglaota");
            conn = new MySqlConnection(connstring);
        }
        private static ketnoi _khoitao = null;
        public static ketnoi Khoitao(string host)
        {
            if (_khoitao == null)
            {
                _khoitao = new ketnoi(host);
            }
            return _khoitao;
        }
        public void Open()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception)
                {

                    MessageBox.Show("Không kết nối được đến máy chủ ", "Lỗi");
                }
            }
        }
        public void Close()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        #endregion

        #region thao tac
        public string GetPhienban(string tenungdung)
        {
            string kq = null;
            string sql = "select phienban from bangcapnhatphanmem where tenungdung = '" + tenungdung + "'";
            Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dtr = cmd.ExecuteReader();
            dtr.Read();
            kq = dtr[0].ToString();
            Close();
            return kq;
        }

        #endregion
    }
}

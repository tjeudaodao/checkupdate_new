using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
namespace checkUpdate
{
    public partial class Form1 : Form
    {
        string serverMysql = null;
        string serverFtp = null;
        string sophienban = null;
        xulyJSON xlJson;

        public Form1()
        {
            InitializeComponent();
            xlJson = new xulyJSON();
            serverMysql = xlJson.ReadJSON("serverMysql");
            serverFtp = xlJson.ReadJSON("serverFtp");
            sophienban = xlJson.ReadJSON("phienban");
            Kiemtra();
        }
        public void Kiemtra()
        {
           
            string[] danhsachFile = Directory.GetFiles(Application.StartupPath, "*.exe");
            for (int i = 0; i < danhsachFile.Length; i++)
            {
                string tenfile = Path.GetFileNameWithoutExtension(danhsachFile[i]);
                if ( tenfile == "danhmucVM_client")
                {
                    HamKiemtraphienban(tenfile, "vmcnf");
                }
                else if (tenfile == "khocnf")
                {
                    HamKiemtraphienban(tenfile, "khocnf");
                }
                else if (tenfile == "KhuyenMai")
                {
                    HamKiemtraphienban(tenfile, "khuyenmaicnf");
                }
            }
        }
        public void HamKiemtraphienban(string tenungdung,string tentrenSERVER)
        {
            var con = ketnoi.Khoitao(serverMysql);
            string phienbanSV = con.GetPhienban(tentrenSERVER);
            lbtenungdung.Text = tenungdung;
            if (phienbanSV != sophienban)
            {
                pbloading.Visible = true;
                lbnoidung.Text = "Có phiên bản mới !. Đang cập nhật ...";
                ftp ftpH = new ftp(serverFtp, "hts", "hoanglaota");
                ftpH.download("app/luutru/" + tentrenSERVER + "/", Application.StartupPath);
                xlJson.UpdatevalueJSON("phienban", phienbanSV);
                xlJson.UpdatevalueJSON("ngay", DateTime.Now.ToString("dd-MM-yyyy"));
            }
            Process.Start(Application.StartupPath + tenungdung + ".exe");
        }
    }
}

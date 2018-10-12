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
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Threading;

namespace checkUpdate
{
    public partial class Form1 : Form
    {
        Thread hts;

        string serverMysql = "27.72.29.28";
        string serverFtp = @"ftp://27.72.29.28/";
        string sophienban = null;
        xulyJSON xlJson;

        string tenfile;

        public Form1()
        {
            InitializeComponent();
            xlJson = new xulyJSON();
            sophienban = xlJson.ReadJSON("phienban");

            hts = new Thread(Kiemtra);
            hts.IsBackground = true;
            hts.Start();

            
        }
        public void Kiemtra()
        {
            try
            {
                string[] danhsachFile = Directory.GetFiles(Application.StartupPath, "*.exe");
                for (int i = 0; i < danhsachFile.Length; i++)
                {
                    tenfile = Path.GetFileNameWithoutExtension(danhsachFile[i]);
                    if (tenfile == "danhmucVM_client")
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
                Application.Exit();
            }
            catch
            {
                ghiloi.WriteLogError("co loi kiem tra phien ban");
                Khoichay(tenfile);
            }
            
        }
        public void HamKiemtraphienban(string tenungdung,string tentrenSERVER)
        {
            lbtenungdung.Invoke(new MethodInvoker(delegate ()
            {
                lbtenungdung.Text = tenungdung;
            }));
            var con = ketnoi.Khoitao(serverMysql);
            string phienbanSV = con.GetPhienban(tentrenSERVER);
            lbnoidung.Invoke(new MethodInvoker(delegate ()
            {
                lbnoidung.Text = "Có phiên bản mới !. Đang cập nhật ...";
            }));
            
            ftp ftpH = new ftp(serverFtp, "hts", "hoanglaota");
            string[] danhsachFILEDOWN = ftpH.directoryListSimple("app/luutru/" + tentrenSERVER + "/");
            if (danhsachFILEDOWN != null)
            {
                if (!Directory.Exists(Application.StartupPath + @"\backup\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\backup\");
                }
                for (int i = 0; i < danhsachFILEDOWN.Length; i++)
                {
                    if (File.Exists(Application.StartupPath + @"\" + danhsachFILEDOWN[i]))
                    {
                        File.Copy(Application.StartupPath + @"\" + danhsachFILEDOWN[i], Application.StartupPath + @"\backup\" + danhsachFILEDOWN[i]);
                    }
                    ftpH.download("app/luutru/" + tentrenSERVER + "/" + danhsachFILEDOWN[i], Application.StartupPath + @"\" + danhsachFILEDOWN[i]);
                }
                string[,] giatriupdate = new string[,]
                {
                        {"phienban",phienbanSV},
                        {"ngaycapnhat", DateTime.Now.ToString("dd-MM-yyyy") }
                };
                xlJson.UpdatevalueJSON(giatriupdate);
            }


            Khoichay(tenungdung);
        }
        public void Khoichay(string tenungdung)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "/" + tenungdung + ".exe");
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
            Application.Exit();
        }
    }
}

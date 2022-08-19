using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SinhVien.Data;

namespace SinhVien.Controller
{
    internal class Edit_Controller
    {
        public String edit()
        {
            Boolean check = false;

            Employee_Screen ep = System.Windows.Forms.Application.OpenForms["Employee_Screen"] as Employee_Screen;

            try
            {
                for (int i = 0; i <= ep.dataGridView.Rows.Count; i++)
                {
                    if (ep.dataGridView.Rows[i].Cells[0].Value.ToString() == ep.txt_ID.Text)
                    {

                        return "Mã Học Sinh không được trùng";

#pragma warning disable CS0162 // Unreachable code detected
                        check = false;
#pragma warning restore CS0162 // Unreachable code detected

                        break;
                    }

                    check = true;
                }
            }
            catch (NullReferenceException n)
            {
                n.ToString();
            }

            if (check)
            {
                Database.insert("ThongTinSinhVien (MaHS, HoSV, TenSV, Ngaysinh, GioiTinh)", "('" + ep.txt_ID.Text + "', '" + ep.txt_HO.Text + "', '" + ep.txt_TEN.Text + "', '" + ep.dtp_NS.Value + "', '" + ep.cb_GT.Text + "')");

                Database.loadData("ThongTinSinhVien");

                Database.fillGridView(ep.dataGridView);

                return "1";
            } else
            {
                return "0";
            }
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinhVien.Data;


using System.Windows.Forms;



namespace SinhVien.Controller
{
    internal class SignIn_Controller
    {
        public String signIn()
        {
            SignIn_Screen si = new SignIn_Screen();

            for (int i = 0; i < Database.Table.Rows.Count; i++)
            {
                if (Database.Table.Rows[i]["un"].ToString() == si.textBox_un_Text && Database.Table.Rows[i]["pw"].ToString() == si.textBox_pw_Text)
                {
                    Database.update("Accounts", "state = 'Online'", si.textBox_un_Text);

                    SignIn_Screen.getValue = si.textBox_un_Text;

                    return "Đăng nhập thành công";
                    break;
                }
                else if (si.textBox_un_Text == "")
                {
                    //MessageBox.Show(si.textBox_un_Text);
                    si.get();
                    return "Tài khoản không được trống!!";
                    break;
                }
                else if (si.textBox_pw_Text == "")
                {

                    return "Mật khẩu không được trống!!";

                    break;
                }
                else if (Database.Table.Rows[i]["un"].ToString() != si.textBox_un_Text)
                { 

                    return "Tài khoản không chính xác!!";

                    break;
                }
                else if (Database.Table.Rows[i]["pw"].ToString() != si.textBox_pw_Text)
                {

                    return "Mật khẩu không chính xác!!";

                    break;
                } else
                {

                    return "Something went wrong!!";

                }
                
            }

            return null;
        }

        public void openC(String tableName)
        {
            Database.openConnection(tableName);
        }
    }
}

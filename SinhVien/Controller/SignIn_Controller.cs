﻿using System;
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
            SignIn_Screen si = Application.OpenForms["SignIn_Screen"] as SignIn_Screen;

            for (int i = 0; i < Database.Table.Rows.Count; i++)
            {
                if (Database.Table.Rows[i]["un"].ToString() == si.textBox_un.Text && Database.Table.Rows[i]["pw"].ToString() == si.textBox_pw.Text)
                {
                    Database.update("Accounts", "state = 'Online'", si.textBox_un.Text, "L");

                    SignIn_Screen.getValue = si.textBox_un.Text;

                    Database.Table.Clear();

                    return "Đăng nhập thành công";
#pragma warning disable CS0162 // Unreachable code detected
                    break;

                }
                else if (si.textBox_un.Text == "")
                {
                    return "Tài khoản không được trống!!";
                    break;
                }
                else if (si.textBox_pw.Text == "")
                {

                    return "Mật khẩu không được trống!!";

                    break;
                }
                else if (Database.Table.Rows[i]["un"].ToString() != si.textBox_un.Text)
                {

                    return "Tài khoản không chính xác!!";

                    break;
                }
                else if (Database.Table.Rows[i]["pw"].ToString() != si.textBox_pw.Text)
                {

                    return "Mật khẩu không chính xác!!";

                    break;
#pragma warning restore CS0162 // Unreachable code detected
                }
            }

            return "Something went wrong!!";
        }

        public void openC()
        {
            Database.openConnection();
        }

        public void loadData(String tableName)
        {
            Database.loadData(tableName);
        }
    }
}

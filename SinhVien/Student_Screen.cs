using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Student_Screen : Form
    {
        public Student_Screen()
        {
            InitializeComponent();
        }

        private void label_Edit_Click(object sender, EventArgs e)
        {
            textBox_class.Enabled = true;
            textBox_ctdd.Enabled = true;
            textBox_name.Enabled = true;
            button_confirm.Visible = true;
        }

        private void label_so_Click(object sender, EventArgs e)
        {
            
        }

        private void Student_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}

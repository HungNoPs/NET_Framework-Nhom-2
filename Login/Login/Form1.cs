using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            String user_name = txt_user.Text;
            String pass = txt_pass.Text;
            if (user_name.Equals("ndungithue") && pass.Equals("Abc@123"))
                MessageBox.Show("Đăng Nhập Thành Công.");
            else
                MessageBox.Show("Đăng Nhập Thất bại.");
        }
    }
}

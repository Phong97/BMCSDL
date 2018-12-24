using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bao_Mat_CSDL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            int check = user_BLL.Login(txtUsername.Text, txtPassword.Text);
            if (check == 1)
            {
                MessageBox.Show("Dang Nhap Thanh Cong!");
            } else
            {
                MessageBox.Show("Kiem tra lai thong tin dang nhap!");
            }
        }
    }
}

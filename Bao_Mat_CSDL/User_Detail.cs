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
    public partial class User_Detail : Form
    {
        string username = "";
        public User_Detail(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void User_Detail_Load(object sender, EventArgs e)
        {
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            dataGridView1.DataSource = user_BLL.getDetailUser(username);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

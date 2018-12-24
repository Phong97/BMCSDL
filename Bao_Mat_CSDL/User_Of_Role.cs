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
    public partial class User_Of_Role : Form
    {
        string role = "";
        public User_Of_Role(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void User_Of_Role_Load(object sender, EventArgs e)
        {
            BLL.Role_BLL role_BLL = new BLL.Role_BLL();
            dataGridView1.DataSource = role_BLL.getUserOfRole(role);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

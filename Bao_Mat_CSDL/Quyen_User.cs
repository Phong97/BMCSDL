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
    public partial class Quyen_User : Form
    {
        public Quyen_User()
        {
            InitializeComponent();
        }

        private void Quyen_User_Load(object sender, EventArgs e)
        {
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            dataGridView1.DataSource = user_BLL.getQuyenUser();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

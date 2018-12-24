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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QL_USER qL_USER = new QL_USER();
            qL_USER.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QL_PROFILE qL_PROFILE = new QL_PROFILE();
            qL_PROFILE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QL_ROLE qL_ROLE = new QL_ROLE();
            qL_ROLE.Show();
        }

        private void btnQLQuyen_Click(object sender, EventArgs e)
        {
            Quyen_User quyen_User = new Quyen_User();
            quyen_User.Show();
        }
    }
}

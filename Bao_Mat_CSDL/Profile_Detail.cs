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
    public partial class Profile_Detail : Form
    {
        string profile = "";
        public Profile_Detail(string profile)
        {
            InitializeComponent();
            this.profile = profile;
        }

        private void Profile_Detail_Load(object sender, EventArgs e)
        {
            BLL.Profile_BLL role_BLL = new BLL.Profile_BLL();
            dataGridView1.DataSource = role_BLL.getDetailProfile(profile);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

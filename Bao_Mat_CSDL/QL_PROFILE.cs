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
    public partial class QL_PROFILE : Form
    {
        private int command = 0; // 1:add, 2:update
        int currentRow;
        public QL_PROFILE()
        {
            InitializeComponent();
        }
        private void event_start()
        {
            panel2.Enabled = false;
            panel1.Enabled = true;
            dataGridView1.Enabled = false;
            btnDetail.Visible = false;
            if (command == 2)
            {
                txtName.Enabled = false;
            }
        }
        private void event_end()
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
            dataGridView1.Enabled = true;
            txtName.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void init ()
        {
            BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
            event_end();
            dataGridView1.DataSource = profile_BLL.getAll();
            resetText();
        }

        private void QL_PROFILE_Load(object sender, EventArgs e)
        {
            BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
            event_end();
            dataGridView1.DataSource = profile_BLL.getAll();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            event_end();
        }

        private void resetText()
        {
            txtName.Text = "";
            txtConnect.Text = "";
            txtSession.Text = "";
            txtIdle.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetText();
            command = 1;
            event_start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = name;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
            DataTable table = profile_BLL.getOne(txtName.Text);
            txtSession.Text = table.Rows[0].ItemArray[1].ToString();
            txtIdle.Text = table.Rows[1].ItemArray[1].ToString();
            txtConnect.Text = table.Rows[2].ItemArray[1].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            command = 2;
            event_start();
            btnDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
            if (command ==  1)
            {
                profile_BLL.insert(txtName.Text, txtSession.Text, txtConnect.Text, txtIdle.Text);
            }
            else if(command == 2)
            {
                txtName.Enabled = true;
                profile_BLL.update(txtName.Text, txtSession.Text, txtConnect.Text, txtIdle.Text);
            }
            init();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete profile?", "Confirmation",
    MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
                profile_BLL.delete(txtName.Text);
            }
            else
            {
                // code xu li
            }
            init();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Profile_Detail profile_Detail = new Profile_Detail(txtName.Text);
            profile_Detail.Show();
        }
    }
}

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
    public partial class QL_USER : Form
    {
        private int command = 0; // 1:add, 2:update
        int currentRow;
        public QL_USER()
        {
            InitializeComponent();
        }
        private void init ()
        {
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            dataGridView1.DataSource = user_BLL.getAll();
            BLL.Profile_BLL profile_BLL = new BLL.Profile_BLL();
            BLL.TBS_BLL tBS_BLL = new BLL.TBS_BLL();
            cbProfile.Items.Clear();
            foreach (DataRow row in profile_BLL.getAll().Rows)
            {
                cbProfile.Items.Add(row.ItemArray[1]);
            }
            cbProfile.SelectedIndex = 0;
            cbtablespace.Items.Clear();
            foreach (DataRow row in tBS_BLL.getAll().Rows)
            {
                cbtablespace.Items.Add(row.ItemArray[1]);
            }
            cbtablespace.SelectedIndex = 0;
            event_end();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void QL_USER_Load(object sender, EventArgs e)
        {
            init();
        }
        private void event_start()
        {
            panel2.Enabled = false;
            panel1.Enabled = true;
            dataGridView1.Enabled = false;
            if (command == 2)
            {
                txtUsername.Enabled = false;
            } 
        }
        private void event_end()
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
            dataGridView1.Enabled = true;
            txtUsername.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            cbStatus.SelectedIndex = 0;
            btnRole.Enabled = false;
            btnTable.Enabled = false;
            btnDetail.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            event_end();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            command = 1;
            event_start();
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtQuota.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            command = 2;
            event_start();
            btnRole.Enabled = true;
            btnTable.Enabled = true;
            btnDetail.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            if (command == 1)
            {
                string username = txtUsername.Text.Trim();
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string quota = txtQuota.Text.Trim();
                string tablespace = cbtablespace.SelectedItem.ToString().Trim();
                string status = cbStatus.SelectedItem.ToString().Trim();
                string profile = cbProfile.SelectedItem.ToString().Trim();

                user_BLL.insert(username, password, name, profile, tablespace, quota, status);
            } else
            {
                string username = txtUsername.Text.Trim();
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string quota = txtQuota.Text.Trim();
                string tablespace = cbtablespace.SelectedItem.ToString().Trim();
                string status = cbStatus.SelectedItem.ToString().Trim();
                string profile = cbProfile.SelectedItem.ToString().Trim();
                user_BLL.update(username, password, name, profile, tablespace, quota, status);
            }
            init();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete user?", "Confirmation",
                MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                BLL.User_BLL user_BLL = new BLL.User_BLL();
                user_BLL.delete(txtUsername.Text);
                init();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtUsername.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
            txtPassword.Text = "";
            BLL.User_BLL user_BLL = new BLL.User_BLL();
            if (user_BLL.checkStatus(txtUsername.Text) == 1)
            {
                cbStatus.SelectedIndex = 0;
            } 
            else
            {
                cbStatus.SelectedIndex = 1;
            }
            DataRow dataRow = user_BLL.getOne(txtUsername.Text).Rows[0];
            // tablespace
            // profile
            //quota
            string tablespace = dataRow.ItemArray[0].ToString();
            string profile = dataRow.ItemArray[1].ToString();
            string quota = (int.Parse(dataRow.ItemArray[2].ToString())/1024/1024).ToString();
            foreach(var item in cbtablespace.Items)
            {
                if (item.ToString().ToUpper() == tablespace.ToUpper())
                {
                    cbtablespace.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in cbProfile.Items)
            {
                if (item.ToString().ToUpper() == profile.ToUpper())
                {
                    cbProfile.SelectedItem = item;
                    break;
                }
            }
            txtQuota.Text = quota;
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            ROLE_USER rOLE_USER = new ROLE_USER(txtUsername.Text);
            rOLE_USER.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Quyen_Table quyen_Table = new Quyen_Table(txtUsername.Text);
            quyen_Table.Show();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            User_Detail user_Detail = new User_Detail(txtUsername.Text);
            user_Detail.Show();
        }
    }
}

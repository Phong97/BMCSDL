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
    public partial class QL_ROLE : Form
    {
        private int command = 0; // 1:add, 2:update
        int currentRow;
        public QL_ROLE()
        {
            InitializeComponent();
        }
        private void event_start()
        {
            panel2.Enabled = false;
            panel1.Enabled = true;
            dataGridView1.Enabled = false;
            if (command == 2)
            {
                txtPassword.Enabled = false;
            }
        }
        private void event_end()
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
            dataGridView1.Enabled = true;
            txtPassword.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            panel3.Enabled = false;
            btnSave.Enabled = true;
        }
        private void init()
        {
            BLL.Role_BLL role_BLL = new BLL.Role_BLL();
            event_end();
            dataGridView1.DataSource = role_BLL.getAll();
            resetText();
        }
        private void resetText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        private void QL_ROLE_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            event_start();
            resetText();
            command = 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUsername.Enabled = false;
            panel3.Enabled = true;
            event_start();
            command = 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            event_end();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BLL.Role_BLL role_BLL = new BLL.Role_BLL();
            string password = txtPassword.Text;
            if (password == "")
            {
                password = "-1";
            }
            if (command == 1)
            {
                role_BLL.insert(txtUsername.Text, password);
            } else
            {
                if (password == "-1")
                {
                    MessageBox.Show("Vui lòng nhập password hợp lệ(khác -1 và rỗng)!");
                } else
                {
                    role_BLL.update(txtUsername.Text, password);
                }
            }
            init();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete role?", "Confirmation",
MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                BLL.Role_BLL role_BLL = new BLL.Role_BLL();
                role_BLL.delete(txtUsername.Text);
            }
            init();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (txtPassword.Text == "-1")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            QUYEN_HT qUYEN_HT = new QUYEN_HT(txtUsername.Text);
            qUYEN_HT.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Quyen_Table quyen_Table = new Quyen_Table(txtUsername.Text);
            quyen_Table.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            User_Of_Role user_Of_Role = new User_Of_Role(txtUsername.Text);
            user_Of_Role.Show();
        }

        private void btnTable_Click_1(object sender, EventArgs e)
        {
            Quyen_Table_Role quyen_Table_Role = new Quyen_Table_Role(txtUsername.Text);
            quyen_Table_Role.Show();
        }
    }
}

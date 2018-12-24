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
    public partial class Quyen_Table_Role : Form
    {
        string username = "";
        List<quyen> quyens = new List<quyen>();
        public Quyen_Table_Role(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Quyen_Table_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgvName = new DataGridViewTextBoxColumn();
            dgvName.HeaderText = "Name";
            DataGridViewCheckBoxColumn dgvSelect = new DataGridViewCheckBoxColumn();
            dgvSelect.HeaderText = "Select";
            dataGridView1.Columns.Add(dgvName);
            dataGridView1.Columns.Add(dgvSelect);
            BLL.Quyen_BLL quyen_BLL = new BLL.Quyen_BLL();
            DataTable quyenTable = quyen_BLL.getByType2();

            foreach (DataRow row in quyenTable.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[0].ToString(), false, false);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            DataTable table = quyen_BLL.getTable();
            foreach (DataRow row in table.Rows)
            {
                cbTable.Items.Add(row.ItemArray[0].ToString());
            }
            cbTable.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if (column == 1)
            {
                bool chk = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                chk = !chk;
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = chk;
            }
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BLL.Quyen_BLL quyen_BLL = new BLL.Quyen_BLL();
            DataTable quyenRoleOnTable = quyen_BLL.getQuyenTableRole(username);
            DataTable quyenTable = quyen_BLL.getByType2();
            foreach (DataRow row in quyenTable.Rows)
            {
                bool select = false;
                bool grant = false;
                foreach (DataRow row1 in quyenRoleOnTable.Rows)
                {
                    if (row1.ItemArray[0].ToString().ToUpper().Equals(cbTable.SelectedItem.ToString().ToUpper()))
                    {
                        if (row.ItemArray[0].ToString().ToUpper().Equals(row1.ItemArray[1].ToString().ToUpper()))
                        {
                            select = true;
                        }
                    }
                }
                dataGridView1.Rows.Add(row.ItemArray[0].ToString(), select, grant);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BLL.Quyen_BLL quyenBLL = new BLL.Quyen_BLL();
            quyenBLL.removeQuyenTable(cbTable.SelectedItem.ToString(), username);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool chk = (bool)row.Cells[1].Value;
                if (chk)
                {
                    quyen quyen;
                    quyen = new quyen(row.Cells[0].Value.ToString(), "-1");
                    quyens.Add(quyen);
                }
            }
            foreach (quyen item in quyens)
            {
                quyenBLL.updateTable(username, item.name, item.grant, cbTable.SelectedItem.ToString());
            }
            MessageBox.Show("Thanh Cong");
        }
    }
}

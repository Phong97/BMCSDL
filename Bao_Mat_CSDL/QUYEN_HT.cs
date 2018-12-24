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
    public class quyen
    {
        public string name { get; set; }
        public string grant { get; set; }
        public quyen(string name, string grant)
        {
            this.name = name;
            this.grant = grant;
        }
    }
    public partial class QUYEN_HT : Form
    {
        string role = "";
        List<quyen> quyens = new List<quyen>();
        List<quyen> listQuyen = new List<quyen>();
        public QUYEN_HT(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void QUYEN_HT_Load(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn dgvName = new DataGridViewTextBoxColumn();
            dgvName.HeaderText = "Name";
            DataGridViewCheckBoxColumn dgvSelect = new DataGridViewCheckBoxColumn();
            dgvSelect.HeaderText = "Select";
            DataGridViewCheckBoxColumn dgvGrant = new DataGridViewCheckBoxColumn();
            dgvGrant.HeaderText = "Grant";
            dataGridView1.Columns.Add(dgvName);
            dataGridView1.Columns.Add(dgvSelect);
            dataGridView1.Columns.Add(dgvGrant);
            BLL.Quyen_BLL quyen_BLL = new BLL.Quyen_BLL();
            DataTable role_quyen = quyen_BLL.getQuyenHT(role);
            DataTable quyenTable =  quyen_BLL.getByType1();
            foreach(DataRow row in quyenTable.Rows)
            {
                bool select = false;
                bool grant = false;
                foreach (DataRow row1 in role_quyen.Rows)
                {
                    if (row.ItemArray[0].ToString().ToUpper().Equals(row1.ItemArray[0].ToString().ToUpper()))
                    {
                        select = true;
                        if (row1.ItemArray[1].ToString().Equals("YES"))
                        {
                            grant = true;
                        }
                        quyen quyen = new quyen(row.ItemArray[0].ToString(), grant ? "1" : "-1");
                        listQuyen.Add(quyen);
                    }
                }
                dataGridView1.Rows.Add(row.ItemArray[0].ToString(), select, grant);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            if (column == 1)
            {
                bool chk = (bool)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                chk = !chk;
                dataGridView1.Rows[e.RowIndex].Cells[1].Value = chk;
            } else if (column == 2)
            {
                bool chk = (bool)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                chk = !chk;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = chk;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BLL.Quyen_BLL quyenBLL = new BLL.Quyen_BLL();
            foreach (quyen item in listQuyen)
            {
                quyenBLL.removeQuyenHT(item.name, role);
            }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                bool chk = (bool)row.Cells[1].Value;
                bool grant = (bool)row.Cells[2].Value;
                if (chk)
                {
                    quyen quyen;
                    if (grant)
                    {
                        quyen = new quyen(row.Cells[0].Value.ToString(), "1");
                    } else
                    {
                        quyen = new quyen(row.Cells[0].Value.ToString(), "-1");
                    }
                    quyens.Add(quyen);
                }
            }
            foreach(quyen item in quyens)
            {
                quyenBLL.updateHT(role, item.name, item.grant);
            }
            MessageBox.Show("Thanh Cong");
        }
    }
}

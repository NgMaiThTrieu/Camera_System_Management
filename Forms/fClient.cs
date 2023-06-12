using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Camera_System_Management.Forms
{
    public partial class fClient : Form
    {
        public int cID = 0;
        public fClient()
        {
            InitializeComponent();
            dgvClient.AutoGenerateColumns = false;
        }

        private BUS_Sell _CMSSell = new BUS_Sell();

        private void fClient_Load(object sender, EventArgs e)
        {
            string tempClientCode;
            int code;
            dgvClient.DataSource = _CMSSell.displayAllClient();
            for (int i = 0; i < dgvClient.Rows.Count; i++)
            {
                tempClientCode = dgvClient.Rows[i].Cells[0].Value.ToString();
                code = int.Parse(tempClientCode.Substring(3, tempClientCode.Length - 3));

                if (cID < code)
                    cID = code;
            }
            cID++;
            lblClientCode.Text = string.Format("CLI{0}", cID < 10 ? "0" + cID.ToString() : cID.ToString());
            dgvClient.DataSource = _CMSSell.displayClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_Client cli = new DTO_Client()
            {
                ClientID = lblClientCode.Text,
                FullName = txtFullName.Text,
                NumberPhone = txtNumberPhone.Text,
            };

            if (_CMSSell.addClient(cli))
            {
                MessageBox.Show("More successful customers");
                fClient_Load(sender, e);
            }
            else
            {
                MessageBox.Show("More failed customers");
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumberPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

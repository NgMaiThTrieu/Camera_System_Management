using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Camera_System_Management.Forms
{
    public partial class fAssi : Form
    {
        private BUS_Assi _assi = new BUS_Assi();
        public fAssi()
        {
            InitializeComponent();
            dgvAssi.AutoGenerateColumns = false;
        }

        private void fAssi_Load(object sender, EventArgs e)
        {
            dgvAssi.DataSource = _assi.LoadListAssi();
        }

        private void dgvAssi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {

        public StockMain()
        {
            InitializeComponent();
        
        }

        private void StockMain_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StockMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

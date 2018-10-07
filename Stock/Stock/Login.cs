using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=,;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [Stock].[dbo].[Login] where UserName ='"+textBox1.Text +"'and Password ='"+textBox2.Text +"'", con);
            DataTable dt=new DataTable ();
           
            sda.Fill(dt);
             this.Hide();
            StockMain main = new StockMain();
            main.Show();

        }
    }
}

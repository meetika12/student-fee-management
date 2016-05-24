using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        int x;
        SqlCommand scmd1;
        SqlConnection scon1;
        string s1=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PRATIKSHA\Documents\Table1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scon1 = new SqlConnection(s1);
            scon1.Open();
            x = Convert.ToInt32(textBox1.Text);
            scmd1 = new SqlCommand("select * from Records where Id="+x+"", scon1);
            scmd1.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(scmd1);
            DataSet ds = new DataSet();
            sda.Fill(ds,"student");
            dataGridView1.DataMember = "student";
            dataGridView1.DataSource = ds;
            scon1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

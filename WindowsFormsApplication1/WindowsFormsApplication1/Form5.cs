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
    public partial class Form5 : Form
    {
         SqlCommand scmd;
        SqlConnection scon;
        string s=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PRATIKSHA\Documents\Table1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form5()
        {
            InitializeComponent();
        }
          
        
        private void button1_Click(object sender, EventArgs e)
        {
            scon = new SqlConnection(s);
            scon.Open();
            int x= Convert.ToInt32(textBox1.Text);

            scmd = new SqlCommand("delete from Records where Id="+x+"", scon);
            scmd.ExecuteNonQuery();
            scon.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
        
        }
    }
}

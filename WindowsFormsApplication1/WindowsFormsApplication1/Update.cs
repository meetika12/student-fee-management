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
    public partial class Update : Form
    {
        SqlCommand scmd1;
        SqlConnection scon1;
        string s2=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PRATIKSHA\Documents\Table1.mdf;Integrated Security=True;Connect Timeout=30";
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scon1 = new SqlConnection(s2);
            scon1.Open();
            int x = Convert.ToInt32(textBox1.Text);
            int p;
            p = Convert.ToInt32(textBox8.Text);
            Decimal q, r;
            q = Convert.ToDecimal(textBox3.Text);
            r = Convert.ToDecimal(textBox5.Text);

            scon1 = new SqlConnection(s2);
            scon1.Open();
            scmd1 = new SqlCommand("update Records where Id=" + x + "", scon1);

            string gen;
            if (radioButton1.Checked)
            {
                gen = "male";
            }
            else
            {
                gen = "female";
            }
/*             scmd1 = new SqlCommand("Update Records (Name,Age,Gender,Course,C1,Father_name,C2,Permanent_Address,City,State,Pincode)values ('" + textBox2.Text + "','" + numericUpDown1.Value + "','" + gen + "','" + textBox9.Text + "','" + q + "','" + textBox4.Text + "','" + r + "','" + textBox7.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + p + "') where Id='"+x+"'", scon1);
            */
           // scmd1 = new SqlCommand("update Records set Name='"+textBox2.Text+"',Age='"+numericUpDown1.Value+"',);
            scmd1.ExecuteNonQuery();
            scon1.Close();
 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

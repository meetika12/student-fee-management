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
    public partial class Form2 : Form
    {
        SqlCommand scmd;
        SqlConnection scon;
        string s=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\PRATIKSHA\Documents\Table1.mdf;Integrated Security=True;Connect Timeout=30";
        int a, b;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            scon = new SqlConnection(s);
            scon.Open();
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox8.Text);
            Decimal c, d;
            c = Convert.ToDecimal(textBox3.Text);
            d = Convert.ToDecimal(textBox5.Text);
            string gen;
            if (radioButton1.Checked)
            {
                gen = "male";
            }
            else {
                gen = "female";
            }
            scmd = new SqlCommand("Insert into Records (Id,Name,Age,Gender,Course,C1,Father_name,C2,Permanent_Address,City,State,Pincode)values ('" + a + "','" + textBox2.Text + "','" + numericUpDown1.Value + "','" + gen + "','" + textBox9.Text + "','" + c + "','" + textBox4.Text + "','" + d + "','" + textBox7.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedItem.ToString() + "','" + b + "')", scon);

            /*scmd = new SqlCommand("Insert into Records (Id,Name,Gender,Course,C1,Father_name,C2,Permanent_Address,Pincode)values ('" + 123 + "','" + "Pratiksha"+ "','" + "Female" + "','" + "BE" + "','" + 1234567898 + "','" + "XYZ" + "','" + 1232254323 + "','" + "DVjg hjfh" + "','" + 434443 + "')", scon);*/
          /*  scmd = new SqlCommand("insert into Records(Id,Name,Age,Course,City)values('" + 373 + "','" + textBox2.Text + "','"+numericUpDown1 .Value +"','" + textBox9.Text + "','"+comboBox1 .SelectedItem .ToString ()+"')", scon);*/
            
            scmd.ExecuteNonQuery();
            scon.Close();
            MessageBox.Show("successfully inserted...!!");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

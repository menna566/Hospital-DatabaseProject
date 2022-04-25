using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospital_DBDataSet.PATIENT' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-10I06SO;Initial Catalog=Hospital_DB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "INSERT INTO PATIENT VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"')";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Successful Insertion");
            sqlconnection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pATIENTTableAdapter.Fill(this.hospital_DBDataSet.PATIENT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-10I06SO;Initial Catalog=Hospital_DB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "UPDATE PATIENT SET PATIENTNAME = '" + textBox3.Text + "' WHERE PATIENTID ='"+textBox1.Text+"'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Successful Update");
            sqlconnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=DESKTOP-10I06SO;Initial Catalog=Hospital_DB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlconnection;
            sqlconnection.Open();
            sqlCommand.CommandText = "DELETE FROM PATIENT WHERE PATIENTID ='" + textBox1.Text + "'";
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Successful Deletion");
            sqlconnection.Close();

        }
    }
}

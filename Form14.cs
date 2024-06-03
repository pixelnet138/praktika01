using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ДИПЛОМ
{
    public partial class Form14 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form14()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton4.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton7.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton11.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton4.Checked == true)
            {
                points = points + 1;
            }
            if (radioButton14.Checked == true)
            {
                points = points + 1;
            }
            if (textBox3.Text == "0")
            {
                points = points + 1;
            }
            textBox2.Text = Convert.ToString(points);
            int tema = 1;
            int uchenik = Convert.ToInt32(textBox1.Text);
            int ocenka = Convert.ToInt32(textBox2.Text);
            string query = "INSERT INTO [Result]([id_test],[id_uchenik],[Ocenka]) VALUES (" + tema + ",'" + uchenik + "','" + ocenka + "')";
            OleDbCommand command = new OleDbCommand(query, Myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о вашем результате по тесту добавлены");
        }
    }
}

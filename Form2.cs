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
    public partial class Form2 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form2()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Myconnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter ada = new OleDbDataAdapter("SELECT * FROM Avtorizatsia WHERE User ='" + textBox1.Text + "'AND Password = '" + textBox2.Text + "'", Myconnection);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            if (dt.Rows[0][0].ToString()=="2")
            {
                Form4 af = new Form4();
                af.Owner = this;
                af.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}

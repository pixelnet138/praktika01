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
    public partial class Form10 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form10()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nazvanie = textBox2.Text;
            string Data = maskedTextBox1.Text;
            string Otvet = textBox1.Text;
            string query = "INSERT INTO [Spisok kursov]([Nomer kursa],[Data postuplenia],[Kolva studentov]) VALUES ('" + Nazvanie + "','" + Data + "','" + Otvet + "')";
            OleDbCommand command = new OleDbCommand(query, Myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о группе добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

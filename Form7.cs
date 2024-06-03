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
    public partial class Form7 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form7()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nazvanie = richTextBox1.Text;
            string Data = maskedTextBox1.Text;
            string Reshenie = richTextBox2.Text;
            string Otvet = textBox1.Text;
            string query = "INSERT INTO [Zadanie]([Opisanie],[Data sdachi],[Reshenie],[Otvet]) VALUES ('" + Nazvanie + "','" + Data + "','" + Reshenie + "','" + Otvet + "')";
            OleDbCommand command = new OleDbCommand(query, Myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о задании добавлены");
        }
    }
}

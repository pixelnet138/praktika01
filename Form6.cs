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
    public partial class Form6 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form6()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nazvanie = textBox1.Text;
            string Opisanie = richTextBox1.Text;
            bool provereno = Convert.ToBoolean(checkBox1.Text);
            string query= "INSERT INTO [Tema]([Nazvanie],[Opisanie],[Osvoena tema]) VALUES ('" + Nazvanie + "','" + Opisanie + "','" + provereno + "')";
            OleDbCommand command = new OleDbCommand(query, Myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о теме добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

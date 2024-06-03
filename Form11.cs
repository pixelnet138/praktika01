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
    public partial class Form11 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form11()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Familia = textBox2.Text;
            string Ima = textBox3.Text;
            string Otchestvo = textBox4.Text;
            string Data = maskedTextBox1.Text;
            string Pasport = textBox1.Text;
            string kurs = comboBox1.Text;
            string query = "INSERT INTO [Uchaisa]([Familia],[Ima],[Otchestvo],[Data_rozhdenia],[Pasport_danie],[id_kurs]) VALUES ('" + Familia + "','" + Ima + "','" + Otchestvo + "','" + Data + "','" + Pasport + "','" + kurs + "')";
            OleDbCommand command = new OleDbCommand(query, Myconnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о студенте добавлены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Spisok_kursov". При необходимости она может быть перемещена или удалена.
            this.spisok_kursovTableAdapter.Fill(this.дИПЛОМDataSet.Spisok_kursov);

        }
    }
}

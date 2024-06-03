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
    public partial class Form5 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form5()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Myconnection.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Spisok_kursov". При необходимости она может быть перемещена или удалена.
            this.spisok_kursovTableAdapter.Fill(this.дИПЛОМDataSet.Spisok_kursov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.DZ". При необходимости она может быть перемещена или удалена.
            this.dZTableAdapter.Fill(this.дИПЛОМDataSet.DZ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Zadanie". При необходимости она может быть перемещена или удалена.
            this.zadanieTableAdapter.Fill(this.дИПЛОМDataSet.Zadanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Tema". При необходимости она может быть перемещена или удалена.
            this.temaTableAdapter.Fill(this.дИПЛОМDataSet.Tema);

        }

        private void темаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 af = new Form6();
            af.Owner = this;
            af.Show();
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 af = new Form7();
            af.Owner = this;
            af.Show();
        }

        private void списокУчениковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 af = new Form8();
            af.Owner = this;
            af.Show();
        }

        private void домашнееЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 af = new Form9();
            af.Owner = this;
            af.Show();
        }

        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 af = new Form10();
            af.Owner = this;
            af.Show();
        }

        private void студентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 af = new Form11();
            af.Owner = this;
            af.Show();
        }

        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 af = new Form12();
            af.Owner = this;
            af.Show();
        }

        private void теорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 af = new Form17();
            af.Owner = this;
            af.Show();
        }

        private void лекцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 af = new Form18();
            af.Owner = this;
            af.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");
        }
    }
}

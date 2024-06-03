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
    public partial class Form4 : Form
    {
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form4()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Tema". При необходимости она может быть перемещена или удалена.
            this.temaTableAdapter.Fill(this.дИПЛОМDataSet.Tema);

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Myconnection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Myconnection.Close();
        }

        private void выполнитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 af = new Form13();
            af.Owner = this;
            af.Show();
        }

        private void теорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 af = new Form17();
            af.Owner = this;
            af.Show();
        }

        private void заданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 af = new Form18();
            af.Owner = this;
            af.Show();
        }
    }
}

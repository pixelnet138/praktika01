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
using Word = Microsoft.Office.Interop.Word;

namespace ДИПЛОМ
{
    public partial class Form8 : Form
    {
        private readonly string TemplateFileName = @"C:\Users\Home\Desktop\САМЫЙ ГЛАВНЙ ДИПЛОМ\Отчет студентов.docx";
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form8()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Spisok_kursov". При необходимости она может быть перемещена или удалена.
            this.spisok_kursovTableAdapter.Fill(this.дИПЛОМDataSet.Spisok_kursov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Uchaisa". При необходимости она может быть перемещена или удалена.
            this.uchaisaTableAdapter.Fill(this.дИПЛОМDataSet.Uchaisa);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            uchaisaBindingSource.Filter = "Familia=\'" + toolStripTextBox1 + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            uchaisaBindingSource.Filter = null;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            uchaisaBindingSource.Filter = "id_kurs=\'" + toolStripTextBox2 + "\'";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            uchaisaBindingSource.Filter = null;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            uchaisaTableAdapter.Update(дИПЛОМDataSet);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            String d = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            String s = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            String a = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            String w = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            String q = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            String y = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            var wordAPP = new Word.Application();
            wordAPP.Visible = false;

            var wordDocument = wordAPP.Documents.Open(TemplateFileName);
            ReplaceWordStud("{familia}", d, wordDocument);
            ReplaceWordStud("{ima}", s, wordDocument);
            ReplaceWordStud("{otchestvo}", a, wordDocument);
            ReplaceWordStud("{data}", w, wordDocument);
            ReplaceWordStud("{pasport}", q, wordDocument);
            ReplaceWordStud("{kurs}", y, wordDocument);
            wordDocument.SaveAs(@"C:\Users\Home\Desktop\САМЫЙ ГЛАВНЙ ДИПЛОМ\Отчет студентовFF.docx");
            wordAPP.Visible = true;
        }
        private void ReplaceWordStud(string studToReplace, string text, Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: studToReplace, ReplaceWith: text);
        }
    }
}

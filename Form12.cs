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
    public partial class Form12 : Form
    {
        private readonly string TemplateFileName = @"C:\Users\Home\Desktop\САМЫЙ ГЛАВНЙ ДИПЛОМ\Отчет тестирования.docx";
        public static string connectSrting = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ДИПЛОМ.mdb";
        private OleDbConnection Myconnection;
        public Form12()
        {
            Myconnection = new OleDbConnection(connectSrting);
            Myconnection.Open();
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Uchaisa". При необходимости она может быть перемещена или удалена.
            this.uchaisaTableAdapter.Fill(this.дИПЛОМDataSet.Uchaisa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.дИПЛОМDataSet.Test);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "дИПЛОМDataSet.Result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.дИПЛОМDataSet.Result);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            resultBindingSource.Filter= "id_test=\'" + toolStripTextBox1 + "\'";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            resultBindingSource.Filter = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            resultBindingSource.Filter = "id_uchenik=\'" + toolStripTextBox2 + "\'";
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            resultBindingSource.Filter = null;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            resultTableAdapter.Update(дИПЛОМDataSet);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            String d = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            String s = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            String a = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            var wordAPP = new Word.Application();
            wordAPP.Visible = false;

            var wordDocument = wordAPP.Documents.Open(TemplateFileName);
            ReplaceWordStud("{test}", d, wordDocument);
            ReplaceWordStud("{bilet}", s, wordDocument);
            ReplaceWordStud("{ocenka}", a, wordDocument);
            wordDocument.SaveAs(@"C:\Users\Home\Desktop\САМЫЙ ГЛАВНЙ ДИПЛОМ\Отчет тестированияFF.docx");
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

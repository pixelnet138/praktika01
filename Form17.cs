using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДИПЛОМ
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файлы Adobe PDF (*.pdf)|*.pdf";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"САМЫЙ ГЛАВНЙ ДИПЛОМ\ДИПЛОМ\Lekciy";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = openFileDialog1.FileName;
            }
        }
    }
}

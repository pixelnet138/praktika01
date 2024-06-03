
namespace ДИПЛОМ
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.temaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дИПЛОМDataSet = new ДИПЛОМ.ДИПЛОМDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.temaTableAdapter = new ДИПЛОМ.ДИПЛОМDataSetTableAdapters.TemaTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеЗаданийПоТемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнитьТестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конспектыТеорийИЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теорияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дИПЛОМDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Содержание программы";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 411);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(491, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Лекции по выбору темы";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(496, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 411);
            this.panel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temaBindingSource, "Opisanie", true));
            this.richTextBox1.Location = new System.Drawing.Point(7, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(818, 322);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // temaBindingSource
            // 
            this.temaBindingSource.DataMember = "Tema";
            this.temaBindingSource.DataSource = this.дИПЛОМDataSet;
            // 
            // дИПЛОМDataSet
            // 
            this.дИПЛОМDataSet.DataSetName = "ДИПЛОМDataSet";
            this.дИПЛОМDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.temaBindingSource;
            this.comboBox1.DisplayMember = "Nazvanie";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(648, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID_tema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выберите тему";
            // 
            // temaTableAdapter
            // 
            this.temaTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выполнениеЗаданийПоТемеToolStripMenuItem,
            this.выполнитьТестToolStripMenuItem,
            this.конспектыТеорийИЗаданийToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // выполнениеЗаданийПоТемеToolStripMenuItem
            // 
            this.выполнениеЗаданийПоТемеToolStripMenuItem.Name = "выполнениеЗаданийПоТемеToolStripMenuItem";
            this.выполнениеЗаданийПоТемеToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.выполнениеЗаданийПоТемеToolStripMenuItem.Text = "Выполнение заданий по теме";
            // 
            // выполнитьТестToolStripMenuItem
            // 
            this.выполнитьТестToolStripMenuItem.Name = "выполнитьТестToolStripMenuItem";
            this.выполнитьТестToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.выполнитьТестToolStripMenuItem.Text = "Выполнить тест";
            this.выполнитьТестToolStripMenuItem.Click += new System.EventHandler(this.выполнитьТестToolStripMenuItem_Click);
            // 
            // конспектыТеорийИЗаданийToolStripMenuItem
            // 
            this.конспектыТеорийИЗаданийToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теорияToolStripMenuItem,
            this.заданияToolStripMenuItem});
            this.конспектыТеорийИЗаданийToolStripMenuItem.Name = "конспектыТеорийИЗаданийToolStripMenuItem";
            this.конспектыТеорийИЗаданийToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.конспектыТеорийИЗаданийToolStripMenuItem.Text = "Конспекты теорий и заданий";
            // 
            // теорияToolStripMenuItem
            // 
            this.теорияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("теорияToolStripMenuItem.Image")));
            this.теорияToolStripMenuItem.Name = "теорияToolStripMenuItem";
            this.теорияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.теорияToolStripMenuItem.Text = "Теория";
            this.теорияToolStripMenuItem.Click += new System.EventHandler(this.теорияToolStripMenuItem_Click);
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("заданияToolStripMenuItem.Image")));
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.заданияToolStripMenuItem.Text = "Задания";
            this.заданияToolStripMenuItem.Click += new System.EventHandler(this.заданияToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1386, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма студента";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дИПЛОМDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private ДИПЛОМDataSet дИПЛОМDataSet;
        private System.Windows.Forms.BindingSource temaBindingSource;
        private ДИПЛОМDataSetTableAdapters.TemaTableAdapter temaTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеЗаданийПоТемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнитьТестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конспектыТеорийИЗаданийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теорияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
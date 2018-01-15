namespace FileKiller
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_letter = new System.Windows.Forms.Label();
            this.radioButton_ASCII = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton_RandomData = new System.Windows.Forms.RadioButton();
            this.radioButton_Blanks = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_ClearGrid = new System.Windows.Forms.Button();
            this.button_SelectFiles = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.Button_KillFiles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_Filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_NumOfFiles = new System.Windows.Forms.Label();
            this.label_NumOfFilesTitle = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.button_ClearGrid);
            this.splitContainer1.Panel1.Controls.Add(this.button_SelectFiles);
            this.splitContainer1.Panel1.Controls.Add(this.button_Quit);
            this.splitContainer1.Panel1.Controls.Add(this.Button_KillFiles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(711, 373);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "(от 1 до 100)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "О программе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_letter);
            this.groupBox1.Controls.Add(this.radioButton_ASCII);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.radioButton_RandomData);
            this.groupBox1.Controls.Add(this.radioButton_Blanks);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 96);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод очистки";
            // 
            // label_letter
            // 
            this.label_letter.AutoSize = true;
            this.label_letter.Enabled = false;
            this.label_letter.ForeColor = System.Drawing.Color.Blue;
            this.label_letter.Location = new System.Drawing.Point(113, 71);
            this.label_letter.Name = "label_letter";
            this.label_letter.Size = new System.Drawing.Size(14, 13);
            this.label_letter.TabIndex = 9;
            this.label_letter.Text = "A";
            // 
            // radioButton_ASCII
            // 
            this.radioButton_ASCII.AutoSize = true;
            this.radioButton_ASCII.Location = new System.Drawing.Point(6, 69);
            this.radioButton_ASCII.Name = "radioButton_ASCII";
            this.radioButton_ASCII.Size = new System.Drawing.Size(52, 17);
            this.radioButton_ASCII.TabIndex = 8;
            this.radioButton_ASCII.Text = "ASCII";
            this.radioButton_ASCII.UseVisualStyleBackColor = true;
            this.radioButton_ASCII.CheckedChanged += new System.EventHandler(this.radioButton_ASCII_CheckedChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.AccessibleDescription = "";
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(62, 69);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Tag = "";
            this.numericUpDown2.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // radioButton_RandomData
            // 
            this.radioButton_RandomData.AutoSize = true;
            this.radioButton_RandomData.Checked = true;
            this.radioButton_RandomData.Location = new System.Drawing.Point(6, 19);
            this.radioButton_RandomData.Name = "radioButton_RandomData";
            this.radioButton_RandomData.Size = new System.Drawing.Size(121, 17);
            this.radioButton_RandomData.TabIndex = 0;
            this.radioButton_RandomData.TabStop = true;
            this.radioButton_RandomData.Text = "Случайные данные";
            this.radioButton_RandomData.UseVisualStyleBackColor = true;
            // 
            // radioButton_Blanks
            // 
            this.radioButton_Blanks.AutoSize = true;
            this.radioButton_Blanks.Location = new System.Drawing.Point(6, 44);
            this.radioButton_Blanks.Name = "radioButton_Blanks";
            this.radioButton_Blanks.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Blanks.TabIndex = 1;
            this.radioButton_Blanks.Text = "Нули";
            this.radioButton_Blanks.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во итераций";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AccessibleDescription = "";
            this.numericUpDown1.Location = new System.Drawing.Point(103, 84);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Tag = "";
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_ClearGrid
            // 
            this.button_ClearGrid.Location = new System.Drawing.Point(12, 227);
            this.button_ClearGrid.Name = "button_ClearGrid";
            this.button_ClearGrid.Size = new System.Drawing.Size(127, 23);
            this.button_ClearGrid.TabIndex = 4;
            this.button_ClearGrid.Text = "Очистить таблицу";
            this.button_ClearGrid.UseVisualStyleBackColor = true;
            this.button_ClearGrid.Click += new System.EventHandler(this.button_ClearGrid_Click);
            // 
            // button_SelectFiles
            // 
            this.button_SelectFiles.Location = new System.Drawing.Point(12, 12);
            this.button_SelectFiles.Name = "button_SelectFiles";
            this.button_SelectFiles.Size = new System.Drawing.Size(127, 23);
            this.button_SelectFiles.TabIndex = 0;
            this.button_SelectFiles.Text = "Выбрать файлы";
            this.button_SelectFiles.UseVisualStyleBackColor = true;
            this.button_SelectFiles.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(12, 306);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(127, 23);
            this.button_Quit.TabIndex = 6;
            this.button_Quit.Text = "Выход";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // Button_KillFiles
            // 
            this.Button_KillFiles.ForeColor = System.Drawing.Color.Red;
            this.Button_KillFiles.Location = new System.Drawing.Point(12, 51);
            this.Button_KillFiles.Name = "Button_KillFiles";
            this.Button_KillFiles.Size = new System.Drawing.Size(127, 23);
            this.Button_KillFiles.TabIndex = 1;
            this.Button_KillFiles.Text = "Удалить файлы >>";
            this.Button_KillFiles.UseVisualStyleBackColor = true;
            this.Button_KillFiles.Click += new System.EventHandler(this.Button_KillFiles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Filename});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 373);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column_Filename
            // 
            this.Column_Filename.FillWeight = 500F;
            this.Column_Filename.HeaderText = "Файлы для удаления";
            this.Column_Filename.MinimumWidth = 500;
            this.Column_Filename.Name = "Column_Filename";
            this.Column_Filename.ReadOnly = true;
            this.Column_Filename.Width = 500;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Files to be killed";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 373);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_NumOfFiles);
            this.panel2.Controls.Add(this.label_NumOfFilesTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 38);
            this.panel2.TabIndex = 2;
            // 
            // label_NumOfFiles
            // 
            this.label_NumOfFiles.AutoSize = true;
            this.label_NumOfFiles.Location = new System.Drawing.Point(198, 10);
            this.label_NumOfFiles.Name = "label_NumOfFiles";
            this.label_NumOfFiles.Size = new System.Drawing.Size(13, 13);
            this.label_NumOfFiles.TabIndex = 1;
            this.label_NumOfFiles.Text = "0";
            // 
            // label_NumOfFilesTitle
            // 
            this.label_NumOfFilesTitle.AutoSize = true;
            this.label_NumOfFilesTitle.Location = new System.Drawing.Point(16, 10);
            this.label_NumOfFilesTitle.Name = "label_NumOfFilesTitle";
            this.label_NumOfFilesTitle.Size = new System.Drawing.Size(176, 13);
            this.label_NumOfFilesTitle.TabIndex = 0;
            this.label_NumOfFilesTitle.Text = "Количество выделенных файлов:";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose the temporary directory";
            this.folderBrowserDialog1.SelectedPath = "c:\\temp";
            // 
            // Form1
            // 
            this.AcceptButton = this.button_SelectFiles;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 373);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master remove files - Безвозвратное удаление файлов от КонтинентСвободы.рф";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Button_KillFiles;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_SelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_ClearGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_NumOfFiles;
        private System.Windows.Forms.Label label_NumOfFilesTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_RandomData;
        private System.Windows.Forms.RadioButton radioButton_Blanks;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_ASCII;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_letter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Filename;
    }
}


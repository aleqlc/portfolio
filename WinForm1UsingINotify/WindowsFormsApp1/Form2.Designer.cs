namespace WindowsFormsApp1
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_profile = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_addstring = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_loadTable = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_loadchart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button_openfile = new System.Windows.Forms.Button();
            this.button_goForm5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_loadImage = new System.Windows.Forms.Button();
            this.textBox_imagePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "profile";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(100, 21);
            this.textBox_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(114, 25);
            this.textBox_author.TabIndex = 4;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(100, 98);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(114, 25);
            this.textBox_title.TabIndex = 5;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(100, 136);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(114, 25);
            this.textBox_description.TabIndex = 6;
            // 
            // textBox_profile
            // 
            this.textBox_profile.Location = new System.Drawing.Point(100, 194);
            this.textBox_profile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_profile.Name = "textBox_profile";
            this.textBox_profile.Size = new System.Drawing.Size(114, 25);
            this.textBox_profile.TabIndex = 7;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(122, 245);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(86, 29);
            this.button_save.TabIndex = 8;
            this.button_save.Text = "Insert";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(223, 245);
            this.button_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(86, 29);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(324, 245);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(86, 29);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(17, 245);
            this.button_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(86, 29);
            this.button_create.TabIndex = 11;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(223, 98);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_addstring
            // 
            this.button_addstring.Location = new System.Drawing.Point(367, 95);
            this.button_addstring.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_addstring.Name = "button_addstring";
            this.button_addstring.Size = new System.Drawing.Size(86, 26);
            this.button_addstring.TabIndex = 13;
            this.button_addstring.Text = "Add String";
            this.button_addstring.UseVisualStyleBackColor = true;
            this.button_addstring.Click += new System.EventHandler(this.button_addstring_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(783, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 184);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 281);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(506, 261);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_loadTable
            // 
            this.button_loadTable.Location = new System.Drawing.Point(437, 245);
            this.button_loadTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_loadTable.Name = "button_loadTable";
            this.button_loadTable.Size = new System.Drawing.Size(86, 31);
            this.button_loadTable.TabIndex = 16;
            this.button_loadTable.Text = "Load";
            this.button_loadTable.UseVisualStyleBackColor = true;
            this.button_loadTable.Click += new System.EventHandler(this.button_loadTable_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(769, 513);
            this.button_prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(133, 37);
            this.button_prev.TabIndex = 17;
            this.button_prev.Text = "로그인화면으로";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(549, 204);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "id";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "author";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(353, 300);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // button_loadchart
            // 
            this.button_loadchart.Location = new System.Drawing.Point(658, 513);
            this.button_loadchart.Name = "button_loadchart";
            this.button_loadchart.Size = new System.Drawing.Size(105, 37);
            this.button_loadchart.TabIndex = 19;
            this.button_loadchart.Text = "Load Chart";
            this.button_loadchart.UseVisualStyleBackColor = true;
            this.button_loadchart.Click += new System.EventHandler(this.button_loadchart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_goForm5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_author);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.textBox_description);
            this.groupBox1.Controls.Add(this.button_addstring);
            this.groupBox1.Controls.Add(this.textBox_profile);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 226);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "생년월일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 25);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(296, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "여자";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(232, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "남자";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(549, 513);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(103, 37);
            this.button_openfile.TabIndex = 21;
            this.button_openfile.Text = "Open file";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // button_goForm5
            // 
            this.button_goForm5.Location = new System.Drawing.Point(430, 10);
            this.button_goForm5.Name = "button_goForm5";
            this.button_goForm5.Size = new System.Drawing.Size(75, 46);
            this.button_goForm5.TabIndex = 22;
            this.button_goForm5.Text = "기타기능";
            this.button_goForm5.UseVisualStyleBackColor = true;
            this.button_goForm5.Click += new System.EventHandler(this.button_goForm5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(523, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button_loadImage
            // 
            this.button_loadImage.Location = new System.Drawing.Point(523, 169);
            this.button_loadImage.Name = "button_loadImage";
            this.button_loadImage.Size = new System.Drawing.Size(254, 28);
            this.button_loadImage.TabIndex = 25;
            this.button_loadImage.Text = "이미지불러오기";
            this.button_loadImage.UseVisualStyleBackColor = true;
            this.button_loadImage.Click += new System.EventHandler(this.button_loadImage_Click);
            // 
            // textBox_imagePath
            // 
            this.textBox_imagePath.Location = new System.Drawing.Point(523, 142);
            this.textBox_imagePath.Name = "textBox_imagePath";
            this.textBox_imagePath.Size = new System.Drawing.Size(254, 25);
            this.textBox_imagePath.TabIndex = 22;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.textBox_imagePath);
            this.Controls.Add(this.button_loadImage);
            this.Controls.Add(this.button_openfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_loadchart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_loadTable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_save);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_profile;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_addstring;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_loadTable;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_loadchart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Button button_goForm5;
        private System.Windows.Forms.Button button_loadImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_imagePath;
    }
}
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button_table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_table = new System.Windows.Forms.TextBox();
            this.button_prev = new System.Windows.Forms.Button();
            this.comboBox_Sheet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Detection = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Camera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_goMap = new System.Windows.Forms.Button();
            this.axTimelineControl1 = new AxTimelineAxLib.AxTimelineControl();
            this.button_AddVideo = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_scale003 = new System.Windows.Forms.Button();
            this.button_scale005 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_table
            // 
            this.button_table.Location = new System.Drawing.Point(278, 10);
            this.button_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_table.Name = "button_table";
            this.button_table.Size = new System.Drawing.Size(174, 29);
            this.button_table.TabIndex = 0;
            this.button_table.Text = "새로운 테이블 생성";
            this.button_table.UseVisualStyleBackColor = true;
            this.button_table.Click += new System.EventHandler(this.button_table_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "테이블명";
            // 
            // textBox_table
            // 
            this.textBox_table.Location = new System.Drawing.Point(107, 11);
            this.textBox_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_table.Name = "textBox_table";
            this.textBox_table.Size = new System.Drawing.Size(164, 25);
            this.textBox_table.TabIndex = 2;
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(458, 10);
            this.button_prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(111, 29);
            this.button_prev.TabIndex = 3;
            this.button_prev.Text = "이전화면으로";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // comboBox_Sheet
            // 
            this.comboBox_Sheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Sheet.FormattingEnabled = true;
            this.comboBox_Sheet.Location = new System.Drawing.Point(60, 280);
            this.comboBox_Sheet.Name = "comboBox_Sheet";
            this.comboBox_Sheet.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Sheet.TabIndex = 4;
            this.comboBox_Sheet.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sheet_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(224, 166);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sheet";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(6, 491);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(105, 28);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Detection
            // 
            this.button_Detection.Location = new System.Drawing.Point(13, 55);
            this.button_Detection.Name = "button_Detection";
            this.button_Detection.Size = new System.Drawing.Size(98, 35);
            this.button_Detection.TabIndex = 8;
            this.button_Detection.Text = "얼굴감지";
            this.button_Detection.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 178);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Camera
            // 
            this.comboBox_Camera.FormattingEnabled = true;
            this.comboBox_Camera.Location = new System.Drawing.Point(982, 10);
            this.comboBox_Camera.Name = "comboBox_Camera";
            this.comboBox_Camera.Size = new System.Drawing.Size(121, 23);
            this.comboBox_Camera.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "카메라";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(927, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 139);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(823, 11);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(95, 41);
            this.button_Start.TabIndex = 13;
            this.button_Start.Text = "시작";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_goMap
            // 
            this.button_goMap.Location = new System.Drawing.Point(575, 12);
            this.button_goMap.Name = "button_goMap";
            this.button_goMap.Size = new System.Drawing.Size(143, 27);
            this.button_goMap.TabIndex = 14;
            this.button_goMap.Text = "지도차트화면으로";
            this.button_goMap.UseVisualStyleBackColor = true;
            this.button_goMap.Click += new System.EventHandler(this.button_goMap_Click);
            // 
            // axTimelineControl1
            // 
            this.axTimelineControl1.Enabled = true;
            this.axTimelineControl1.Location = new System.Drawing.Point(258, 199);
            this.axTimelineControl1.Name = "axTimelineControl1";
            this.axTimelineControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTimelineControl1.OcxState")));
            this.axTimelineControl1.Size = new System.Drawing.Size(835, 362);
            this.axTimelineControl1.TabIndex = 15;
            // 
            // button_AddVideo
            // 
            this.button_AddVideo.Location = new System.Drawing.Point(258, 138);
            this.button_AddVideo.Name = "button_AddVideo";
            this.button_AddVideo.Size = new System.Drawing.Size(112, 43);
            this.button_AddVideo.TabIndex = 16;
            this.button_AddVideo.Text = "비디오 추가";
            this.button_AddVideo.UseVisualStyleBackColor = true;
            this.button_AddVideo.Click += new System.EventHandler(this.button_AddVideo_Click);
            // 
            // button_Play
            // 
            this.button_Play.Location = new System.Drawing.Point(394, 138);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(106, 43);
            this.button_Play.TabIndex = 17;
            this.button_Play.Text = "플레이";
            this.button_Play.UseVisualStyleBackColor = true;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(518, 138);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(106, 43);
            this.button_Stop.TabIndex = 18;
            this.button_Stop.Text = "멈춤";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_scale003
            // 
            this.button_scale003.Location = new System.Drawing.Point(645, 139);
            this.button_scale003.Name = "button_scale003";
            this.button_scale003.Size = new System.Drawing.Size(106, 43);
            this.button_scale003.TabIndex = 19;
            this.button_scale003.Text = "스케일0.03";
            this.button_scale003.UseVisualStyleBackColor = true;
            this.button_scale003.Click += new System.EventHandler(this.button_scale003_Click);
            // 
            // button_scale005
            // 
            this.button_scale005.Location = new System.Drawing.Point(770, 138);
            this.button_scale005.Name = "button_scale005";
            this.button_scale005.Size = new System.Drawing.Size(106, 43);
            this.button_scale005.TabIndex = 20;
            this.button_scale005.Text = "스케일 0.05";
            this.button_scale005.UseVisualStyleBackColor = true;
            this.button_scale005.Click += new System.EventHandler(this.button_scale005_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(258, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(551, 78);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 603);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button_scale005);
            this.Controls.Add(this.button_scale003);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Play);
            this.Controls.Add(this.button_AddVideo);
            this.Controls.Add(this.axTimelineControl1);
            this.Controls.Add(this.button_goMap);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Camera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Detection);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Sheet);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.textBox_table);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_table);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTimelineControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_table;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.ComboBox comboBox_Sheet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Detection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Camera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_goMap;
        private AxTimelineAxLib.AxTimelineControl axTimelineControl1;
        private System.Windows.Forms.Button button_AddVideo;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_scale003;
        private System.Windows.Forms.Button button_scale005;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
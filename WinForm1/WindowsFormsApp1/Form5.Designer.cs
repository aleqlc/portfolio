namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button_runExe = new System.Windows.Forms.Button();
            this.button_runPdf = new System.Windows.Forms.Button();
            this.button_beep = new System.Windows.Forms.Button();
            this.button_goForm1 = new System.Windows.Forms.Button();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_playAudio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_makeRandom = new System.Windows.Forms.Button();
            this.button_chooseVideo = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox_pathVideo = new System.Windows.Forms.TextBox();
            this.button_pause = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_chooseMP3 = new System.Windows.Forms.Button();
            this.button_makePDFfile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Plain = new System.Windows.Forms.TextBox();
            this.textBox2_Encrypted = new System.Windows.Forms.TextBox();
            this.textBox3_decrypted = new System.Windows.Forms.TextBox();
            this.button_Encryption = new System.Windows.Forms.Button();
            this.button_Decryption = new System.Windows.Forms.Button();
            this.button_loadPDF = new System.Windows.Forms.Button();
            this.richTextBox_PDF = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_runExe
            // 
            this.button_runExe.Location = new System.Drawing.Point(18, 286);
            this.button_runExe.Name = "button_runExe";
            this.button_runExe.Size = new System.Drawing.Size(108, 43);
            this.button_runExe.TabIndex = 0;
            this.button_runExe.Text = "EXE파일실행";
            this.button_runExe.UseVisualStyleBackColor = true;
            // 
            // button_runPdf
            // 
            this.button_runPdf.Location = new System.Drawing.Point(18, 193);
            this.button_runPdf.Name = "button_runPdf";
            this.button_runPdf.Size = new System.Drawing.Size(108, 43);
            this.button_runPdf.TabIndex = 1;
            this.button_runPdf.Text = "PDF파일실행";
            this.button_runPdf.UseVisualStyleBackColor = true;
            // 
            // button_beep
            // 
            this.button_beep.Location = new System.Drawing.Point(19, 144);
            this.button_beep.Name = "button_beep";
            this.button_beep.Size = new System.Drawing.Size(108, 43);
            this.button_beep.TabIndex = 2;
            this.button_beep.Text = "비프음";
            this.button_beep.UseVisualStyleBackColor = true;
            this.button_beep.Click += new System.EventHandler(this.button_beep_Click);
            // 
            // button_goForm1
            // 
            this.button_goForm1.Location = new System.Drawing.Point(654, 403);
            this.button_goForm1.Name = "button_goForm1";
            this.button_goForm1.Size = new System.Drawing.Size(134, 40);
            this.button_goForm1.TabIndex = 3;
            this.button_goForm1.Text = "첫화면으로";
            this.button_goForm1.UseVisualStyleBackColor = true;
            this.button_goForm1.Click += new System.EventHandler(this.button_goForm1_Click);
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.Location = new System.Drawing.Point(19, 403);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(108, 25);
            this.button_chooseFile.TabIndex = 4;
            this.button_chooseFile.Text = "파일선택하기";
            this.button_chooseFile.UseVisualStyleBackColor = true;
            this.button_chooseFile.Click += new System.EventHandler(this.button_chooseFile_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(139, 403);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(100, 25);
            this.textBox_path.TabIndex = 5;
            // 
            // button_playAudio
            // 
            this.button_playAudio.Location = new System.Drawing.Point(245, 403);
            this.button_playAudio.Name = "button_playAudio";
            this.button_playAudio.Size = new System.Drawing.Size(103, 26);
            this.button_playAudio.TabIndex = 6;
            this.button_playAudio.Text = "재생";
            this.button_playAudio.UseVisualStyleBackColor = true;
            this.button_playAudio.Click += new System.EventHandler(this.button_playAudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "최소값";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "최대값";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "랜덤숫자";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(84, 9);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 25);
            this.textBox_min.TabIndex = 10;
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(83, 43);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 25);
            this.textBox_max.TabIndex = 11;
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(82, 75);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(100, 25);
            this.textBox_result.TabIndex = 12;
            // 
            // button_makeRandom
            // 
            this.button_makeRandom.Location = new System.Drawing.Point(18, 106);
            this.button_makeRandom.Name = "button_makeRandom";
            this.button_makeRandom.Size = new System.Drawing.Size(166, 32);
            this.button_makeRandom.TabIndex = 13;
            this.button_makeRandom.Text = "랜덤숫자만들기";
            this.button_makeRandom.UseVisualStyleBackColor = true;
            this.button_makeRandom.Click += new System.EventHandler(this.button_makeRandom_Click);
            // 
            // button_chooseVideo
            // 
            this.button_chooseVideo.Location = new System.Drawing.Point(472, 9);
            this.button_chooseVideo.Name = "button_chooseVideo";
            this.button_chooseVideo.Size = new System.Drawing.Size(81, 28);
            this.button_chooseVideo.TabIndex = 15;
            this.button_chooseVideo.Text = "파일선택";
            this.button_chooseVideo.UseVisualStyleBackColor = true;
            this.button_chooseVideo.Click += new System.EventHandler(this.button_chooseVideo_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(204, 260);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(81, 38);
            this.button_start.TabIndex = 16;
            this.button_start.Text = "시작";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(385, 260);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(81, 38);
            this.button_stop.TabIndex = 17;
            this.button_stop.Text = "멈춤";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox_pathVideo
            // 
            this.textBox_pathVideo.Location = new System.Drawing.Point(204, 9);
            this.textBox_pathVideo.Name = "textBox_pathVideo";
            this.textBox_pathVideo.Size = new System.Drawing.Size(262, 25);
            this.textBox_pathVideo.TabIndex = 18;
            // 
            // button_pause
            // 
            this.button_pause.Location = new System.Drawing.Point(291, 260);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(88, 38);
            this.button_pause.TabIndex = 19;
            this.button_pause.Text = "일시정지";
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(608, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 154);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_chooseMP3
            // 
            this.button_chooseMP3.Location = new System.Drawing.Point(608, 172);
            this.button_chooseMP3.Name = "button_chooseMP3";
            this.button_chooseMP3.Size = new System.Drawing.Size(180, 23);
            this.button_chooseMP3.TabIndex = 21;
            this.button_chooseMP3.Text = "플레이리스트 선택";
            this.button_chooseMP3.UseVisualStyleBackColor = true;
            this.button_chooseMP3.Click += new System.EventHandler(this.button_chooseMP3_Click);
            // 
            // button_makePDFfile
            // 
            this.button_makePDFfile.Location = new System.Drawing.Point(18, 242);
            this.button_makePDFfile.Name = "button_makePDFfile";
            this.button_makePDFfile.Size = new System.Drawing.Size(108, 38);
            this.button_makePDFfile.TabIndex = 22;
            this.button_makePDFfile.Text = "PDF파일생성";
            this.button_makePDFfile.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(93, 89);
            this.dataGridView1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "텍스트";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "텍스트 암호화";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "암호화 풀기";
            // 
            // textBox1_Plain
            // 
            this.textBox1_Plain.Location = new System.Drawing.Point(581, 211);
            this.textBox1_Plain.Name = "textBox1_Plain";
            this.textBox1_Plain.Size = new System.Drawing.Size(100, 25);
            this.textBox1_Plain.TabIndex = 28;
            // 
            // textBox2_Encrypted
            // 
            this.textBox2_Encrypted.Location = new System.Drawing.Point(581, 239);
            this.textBox2_Encrypted.Name = "textBox2_Encrypted";
            this.textBox2_Encrypted.Size = new System.Drawing.Size(100, 25);
            this.textBox2_Encrypted.TabIndex = 29;
            // 
            // textBox3_decrypted
            // 
            this.textBox3_decrypted.Location = new System.Drawing.Point(581, 269);
            this.textBox3_decrypted.Name = "textBox3_decrypted";
            this.textBox3_decrypted.Size = new System.Drawing.Size(100, 25);
            this.textBox3_decrypted.TabIndex = 30;
            // 
            // button_Encryption
            // 
            this.button_Encryption.Location = new System.Drawing.Point(692, 239);
            this.button_Encryption.Name = "button_Encryption";
            this.button_Encryption.Size = new System.Drawing.Size(92, 25);
            this.button_Encryption.TabIndex = 31;
            this.button_Encryption.Text = "암호화";
            this.button_Encryption.UseVisualStyleBackColor = true;
            this.button_Encryption.Click += new System.EventHandler(this.button_Encryption_Click);
            // 
            // button_Decryption
            // 
            this.button_Decryption.Location = new System.Drawing.Point(692, 266);
            this.button_Decryption.Name = "button_Decryption";
            this.button_Decryption.Size = new System.Drawing.Size(92, 26);
            this.button_Decryption.TabIndex = 32;
            this.button_Decryption.Text = "암호풀기";
            this.button_Decryption.UseVisualStyleBackColor = true;
            this.button_Decryption.Click += new System.EventHandler(this.button_Decryption_Click);
            // 
            // button_loadPDF
            // 
            this.button_loadPDF.Location = new System.Drawing.Point(204, 322);
            this.button_loadPDF.Name = "button_loadPDF";
            this.button_loadPDF.Size = new System.Drawing.Size(75, 49);
            this.button_loadPDF.TabIndex = 33;
            this.button_loadPDF.Text = "PDF불러오기";
            this.button_loadPDF.UseVisualStyleBackColor = true;
            // 
            // richTextBox_PDF
            // 
            this.richTextBox_PDF.Location = new System.Drawing.Point(279, 306);
            this.richTextBox_PDF.Name = "richTextBox_PDF";
            this.richTextBox_PDF.Size = new System.Drawing.Size(312, 91);
            this.richTextBox_PDF.TabIndex = 34;
            this.richTextBox_PDF.Text = "";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(204, 43);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(262, 211);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 600);
            this.Controls.Add(this.richTextBox_PDF);
            this.Controls.Add(this.button_loadPDF);
            this.Controls.Add(this.button_Decryption);
            this.Controls.Add(this.button_Encryption);
            this.Controls.Add(this.textBox3_decrypted);
            this.Controls.Add(this.textBox2_Encrypted);
            this.Controls.Add(this.textBox1_Plain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_makePDFfile);
            this.Controls.Add(this.button_chooseMP3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.textBox_pathVideo);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_chooseVideo);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button_makeRandom);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_playAudio);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_chooseFile);
            this.Controls.Add(this.button_goForm1);
            this.Controls.Add(this.button_beep);
            this.Controls.Add(this.button_runPdf);
            this.Controls.Add(this.button_runExe);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_runExe;
        private System.Windows.Forms.Button button_runPdf;
        private System.Windows.Forms.Button button_beep;
        private System.Windows.Forms.Button button_goForm1;
        private System.Windows.Forms.Button button_chooseFile;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_playAudio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_makeRandom;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button button_chooseVideo;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_pathVideo;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_chooseMP3;
        private System.Windows.Forms.Button button_makePDFfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Plain;
        private System.Windows.Forms.TextBox textBox2_Encrypted;
        private System.Windows.Forms.TextBox textBox3_decrypted;
        private System.Windows.Forms.Button button_Encryption;
        private System.Windows.Forms.Button button_Decryption;
        private System.Windows.Forms.Button button_loadPDF;
        private System.Windows.Forms.RichTextBox richTextBox_PDF;
    }
}
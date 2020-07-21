namespace WindowsFormsApp1
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
            this.button_openfile = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_makefile = new System.Windows.Forms.Button();
            this.button_makeexcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(3, 314);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(126, 27);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "Open file";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(661, 388);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(127, 50);
            this.button_prev.TabIndex = 1;
            this.button_prev.Text = "이전화면으로";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(794, 305);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 25);
            this.textBox1.TabIndex = 3;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(687, 312);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 25);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "검색";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_makefile
            // 
            this.button_makefile.Location = new System.Drawing.Point(3, 359);
            this.button_makefile.Name = "button_makefile";
            this.button_makefile.Size = new System.Drawing.Size(126, 28);
            this.button_makefile.TabIndex = 5;
            this.button_makefile.Text = "파일만들기";
            this.button_makefile.UseVisualStyleBackColor = true;
            this.button_makefile.Click += new System.EventHandler(this.button_makefile_Click);
            // 
            // button_makeexcel
            // 
            this.button_makeexcel.Location = new System.Drawing.Point(3, 402);
            this.button_makeexcel.Name = "button_makeexcel";
            this.button_makeexcel.Size = new System.Drawing.Size(126, 27);
            this.button_makeexcel.TabIndex = 6;
            this.button_makeexcel.Text = "엑셀파일만들기";
            this.button_makeexcel.UseVisualStyleBackColor = true;
            this.button_makeexcel.Click += new System.EventHandler(this.button_makeexcel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_makeexcel);
            this.Controls.Add(this.button_makefile);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_openfile);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_makefile;
        private System.Windows.Forms.Button button_makeexcel;
    }
}
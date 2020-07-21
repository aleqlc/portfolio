namespace WinformCrudWithOracle
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestConn = new System.Windows.Forms.Button();
            this.btnCreateEmpTable = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelData = new System.Windows.Forms.Button();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnGotoF2 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnGotoF3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(13, 13);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(182, 33);
            this.btnTestConn.TabIndex = 0;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // btnCreateEmpTable
            // 
            this.btnCreateEmpTable.Location = new System.Drawing.Point(13, 63);
            this.btnCreateEmpTable.Name = "btnCreateEmpTable";
            this.btnCreateEmpTable.Size = new System.Drawing.Size(182, 32);
            this.btnCreateEmpTable.TabIndex = 1;
            this.btnCreateEmpTable.Text = "Create Employee Table";
            this.btnCreateEmpTable.UseVisualStyleBackColor = true;
            this.btnCreateEmpTable.Click += new System.EventHandler(this.btnCreateEmpTable_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(13, 113);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 32);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelData
            // 
            this.btnDelData.Location = new System.Drawing.Point(13, 217);
            this.btnDelData.Name = "btnDelData";
            this.btnDelData.Size = new System.Drawing.Size(182, 31);
            this.btnDelData.TabIndex = 4;
            this.btnDelData.Text = "Delete Data";
            this.btnDelData.UseVisualStyleBackColor = true;
            this.btnDelData.Click += new System.EventHandler(this.btnDelData_Click);
            // 
            // dgvEmp
            // 
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(507, 63);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.RowHeadersWidth = 51;
            this.dgvEmp.RowTemplate.Height = 27;
            this.dgvEmp.Size = new System.Drawing.Size(531, 342);
            this.dgvEmp.TabIndex = 5;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(507, 32);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(153, 25);
            this.btnShowData.TabIndex = 6;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // btnGotoF2
            // 
            this.btnGotoF2.Location = new System.Drawing.Point(13, 270);
            this.btnGotoF2.Name = "btnGotoF2";
            this.btnGotoF2.Size = new System.Drawing.Size(182, 32);
            this.btnGotoF2.TabIndex = 7;
            this.btnGotoF2.Text = "Go To Form2";
            this.btnGotoF2.UseVisualStyleBackColor = true;
            this.btnGotoF2.Click += new System.EventHandler(this.btnGotoF2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(666, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(354, 25);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(663, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 15);
            this.lblCount.TabIndex = 9;
            // 
            // btnGotoF3
            // 
            this.btnGotoF3.Location = new System.Drawing.Point(13, 321);
            this.btnGotoF3.Name = "btnGotoF3";
            this.btnGotoF3.Size = new System.Drawing.Size(182, 32);
            this.btnGotoF3.TabIndex = 10;
            this.btnGotoF3.Text = "Go To Form3";
            this.btnGotoF3.UseVisualStyleBackColor = true;
            this.btnGotoF3.Click += new System.EventHandler(this.btnGotoF3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 417);
            this.Controls.Add(this.btnGotoF3);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnGotoF2);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.btnDelData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreateEmpTable);
            this.Controls.Add(this.btnTestConn);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Button btnCreateEmpTable;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelData;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.Button btnGotoF2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnGotoF3;
    }
}


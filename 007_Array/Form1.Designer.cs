namespace _007_Array
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOneWeek = new System.Windows.Forms.Button();
            this.btnTwoWeek = new System.Windows.Forms.Button();
            this.lblArrayCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장 방문 수";
            // 
            // dgvDay
            // 
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7});
            this.dgvDay.Location = new System.Drawing.Point(15, 37);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.Size = new System.Drawing.Size(743, 125);
            this.dgvDay.TabIndex = 1;
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.Name = "colDay1";
            // 
            // colDay2
            // 
            this.colDay2.HeaderText = "화";
            this.colDay2.Name = "colDay2";
            // 
            // colDay3
            // 
            this.colDay3.HeaderText = "수";
            this.colDay3.Name = "colDay3";
            // 
            // colDay4
            // 
            this.colDay4.HeaderText = "목";
            this.colDay4.Name = "colDay4";
            // 
            // colDay5
            // 
            this.colDay5.HeaderText = "금";
            this.colDay5.Name = "colDay5";
            // 
            // colDay6
            // 
            this.colDay6.HeaderText = "토";
            this.colDay6.Name = "colDay6";
            // 
            // colDay7
            // 
            this.colDay7.HeaderText = "일";
            this.colDay7.Name = "colDay7";
            // 
            // btnOneWeek
            // 
            this.btnOneWeek.Location = new System.Drawing.Point(15, 178);
            this.btnOneWeek.Name = "btnOneWeek";
            this.btnOneWeek.Size = new System.Drawing.Size(89, 23);
            this.btnOneWeek.TabIndex = 2;
            this.btnOneWeek.Text = "일주일 자료";
            this.btnOneWeek.UseVisualStyleBackColor = true;
            this.btnOneWeek.Click += new System.EventHandler(this.btnOneWeek_Click);
            // 
            // btnTwoWeek
            // 
            this.btnTwoWeek.Location = new System.Drawing.Point(121, 178);
            this.btnTwoWeek.Name = "btnTwoWeek";
            this.btnTwoWeek.Size = new System.Drawing.Size(89, 23);
            this.btnTwoWeek.TabIndex = 3;
            this.btnTwoWeek.Text = "이주일 자료";
            this.btnTwoWeek.UseVisualStyleBackColor = true;
            this.btnTwoWeek.Click += new System.EventHandler(this.btnTwoWeek_Click);
            // 
            // lblArrayCount
            // 
            this.lblArrayCount.AutoSize = true;
            this.lblArrayCount.Location = new System.Drawing.Point(225, 178);
            this.lblArrayCount.Name = "lblArrayCount";
            this.lblArrayCount.Size = new System.Drawing.Size(83, 13);
            this.lblArrayCount.TabIndex = 4;
            this.lblArrayCount.Text = "전체 자료 수 : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 220);
            this.Controls.Add(this.lblArrayCount);
            this.Controls.Add(this.btnTwoWeek);
            this.Controls.Add(this.btnOneWeek);
            this.Controls.Add(this.dgvDay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay7;
        private System.Windows.Forms.Button btnOneWeek;
        private System.Windows.Forms.Button btnTwoWeek;
        private System.Windows.Forms.Label lblArrayCount;
    }
}


namespace _008_Condition
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompare = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelesctedDay = new System.Windows.Forms.Label();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCheckDay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // lblCompare
            // 
            this.lblCompare.AutoSize = true;
            this.lblCompare.Location = new System.Drawing.Point(12, 67);
            this.lblCompare.Name = "lblCompare";
            this.lblCompare.Size = new System.Drawing.Size(82, 13);
            this.lblCompare.TabIndex = 2;
            this.lblCompare.Text = "Compare Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Day";
            // 
            // lblSelesctedDay
            // 
            this.lblSelesctedDay.AutoSize = true;
            this.lblSelesctedDay.Location = new System.Drawing.Point(12, 205);
            this.lblSelesctedDay.Name = "lblSelesctedDay";
            this.lblSelesctedDay.Size = new System.Drawing.Size(71, 13);
            this.lblSelesctedDay.TabIndex = 4;
            this.lblSelesctedDay.Text = "Selected Day";
            // 
            // nNumber1
            // 
            this.nNumber1.Location = new System.Drawing.Point(8, 34);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(67, 20);
            this.nNumber1.TabIndex = 5;
            // 
            // nNumber2
            // 
            this.nNumber2.Location = new System.Drawing.Point(96, 34);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(67, 20);
            this.nNumber2.TabIndex = 6;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbDay.Location = new System.Drawing.Point(15, 149);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(97, 21);
            this.cbDay.TabIndex = 7;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(198, 34);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(103, 23);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCheckDay
            // 
            this.btnCheckDay.Location = new System.Drawing.Point(198, 149);
            this.btnCheckDay.Name = "btnCheckDay";
            this.btnCheckDay.Size = new System.Drawing.Size(103, 23);
            this.btnCheckDay.TabIndex = 9;
            this.btnCheckDay.Text = "Check Day";
            this.btnCheckDay.UseVisualStyleBackColor = true;
            this.btnCheckDay.Click += new System.EventHandler(this.btnCheckDay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 251);
            this.Controls.Add(this.btnCheckDay);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.lblSelesctedDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCompare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelesctedDay;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCheckDay;
    }
}


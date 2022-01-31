namespace _010_DoWhile
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
            this.lblRottery = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRottery = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRottery
            // 
            this.lblRottery.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRottery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRottery.Location = new System.Drawing.Point(12, 9);
            this.lblRottery.Name = "lblRottery";
            this.lblRottery.Size = new System.Drawing.Size(226, 34);
            this.lblRottery.TabIndex = 0;
            this.lblRottery.Text = "0, 0, 0, 0, 0";
            this.lblRottery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(15, 46);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(223, 212);
            this.lbResult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose 1 to 45";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(15, 314);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(58, 20);
            this.tbNumber.TabIndex = 3;
            this.tbNumber.Text = "1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 351);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "-";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(121, 311);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(117, 23);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Get a Number";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(15, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 3);
            this.panel1.TabIndex = 6;
            // 
            // btnRottery
            // 
            this.btnRottery.Location = new System.Drawing.Point(247, 12);
            this.btnRottery.Name = "btnRottery";
            this.btnRottery.Size = new System.Drawing.Size(83, 44);
            this.btnRottery.TabIndex = 7;
            this.btnRottery.Text = "Get Rottery";
            this.btnRottery.UseVisualStyleBackColor = true;
            this.btnRottery.Click += new System.EventHandler(this.btnRottery_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(247, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 44);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 380);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRottery);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lblRottery);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRottery;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRottery;
        private System.Windows.Forms.Button btnClear;
    }
}


namespace DA_18_Huynh
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
            this.vb = new System.Windows.Forms.Label();
            this.ab = new System.Windows.Forms.Label();
            this.aâ = new System.Windows.Forms.Label();
            this.aa = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnRS_18_Huynh = new System.Windows.Forms.Button();
            this.btnPT2_18_Huynh = new System.Windows.Forms.Button();
            this.btnPT1_18_Huynh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vb
            // 
            this.vb.AutoSize = true;
            this.vb.Location = new System.Drawing.Point(240, 237);
            this.vb.Name = "vb";
            this.vb.Size = new System.Drawing.Size(55, 16);
            this.vb.TabIndex = 22;
            this.vb.Text = "Kết quả:";
            // 
            // ab
            // 
            this.ab.AutoSize = true;
            this.ab.Location = new System.Drawing.Point(240, 185);
            this.ab.Name = "ab";
            this.ab.Size = new System.Drawing.Size(58, 16);
            this.ab.TabIndex = 21;
            this.ab.Text = "Hệ số C:";
            // 
            // aâ
            // 
            this.aâ.AutoSize = true;
            this.aâ.Location = new System.Drawing.Point(240, 141);
            this.aâ.Name = "aâ";
            this.aâ.Size = new System.Drawing.Size(58, 16);
            this.aâ.TabIndex = 20;
            this.aâ.Text = "Hệ số B:";
            // 
            // aa
            // 
            this.aa.AutoSize = true;
            this.aa.Location = new System.Drawing.Point(240, 96);
            this.aa.Name = "aa";
            this.aa.Size = new System.Drawing.Size(58, 16);
            this.aa.TabIndex = 19;
            this.aa.Text = "Hệ số A:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(308, 225);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(231, 38);
            this.txtKQ.TabIndex = 18;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(308, 182);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(231, 22);
            this.txtC.TabIndex = 17;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(308, 138);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(231, 22);
            this.txtB.TabIndex = 16;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(308, 93);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(231, 22);
            this.txtA.TabIndex = 15;
            // 
            // btnRS_18_Huynh
            // 
            this.btnRS_18_Huynh.Location = new System.Drawing.Point(497, 302);
            this.btnRS_18_Huynh.Name = "btnRS_18_Huynh";
            this.btnRS_18_Huynh.Size = new System.Drawing.Size(89, 31);
            this.btnRS_18_Huynh.TabIndex = 14;
            this.btnRS_18_Huynh.Text = "Làm lại";
            this.btnRS_18_Huynh.UseVisualStyleBackColor = true;
            this.btnRS_18_Huynh.Click += new System.EventHandler(this.btnRS_18_Huynh_Click);
            // 
            // btnPT2_18_Huynh
            // 
            this.btnPT2_18_Huynh.Location = new System.Drawing.Point(345, 302);
            this.btnPT2_18_Huynh.Name = "btnPT2_18_Huynh";
            this.btnPT2_18_Huynh.Size = new System.Drawing.Size(92, 31);
            this.btnPT2_18_Huynh.TabIndex = 13;
            this.btnPT2_18_Huynh.Text = "Giải PT2";
            this.btnPT2_18_Huynh.UseVisualStyleBackColor = true;
            this.btnPT2_18_Huynh.Click += new System.EventHandler(this.btnPT2_18_Huynh_Click);
            // 
            // btnPT1_18_Huynh
            // 
            this.btnPT1_18_Huynh.Location = new System.Drawing.Point(189, 302);
            this.btnPT1_18_Huynh.Name = "btnPT1_18_Huynh";
            this.btnPT1_18_Huynh.Size = new System.Drawing.Size(92, 31);
            this.btnPT1_18_Huynh.TabIndex = 12;
            this.btnPT1_18_Huynh.Text = "Giải PT1";
            this.btnPT1_18_Huynh.UseVisualStyleBackColor = true;
            this.btnPT1_18_Huynh.Click += new System.EventHandler(this.btnPT1_18_Huynh_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vb);
            this.Controls.Add(this.ab);
            this.Controls.Add(this.aâ);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnRS_18_Huynh);
            this.Controls.Add(this.btnPT2_18_Huynh);
            this.Controls.Add(this.btnPT1_18_Huynh);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label vb;
        private System.Windows.Forms.Label ab;
        private System.Windows.Forms.Label aâ;
        private System.Windows.Forms.Label aa;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnRS_18_Huynh;
        private System.Windows.Forms.Button btnPT2_18_Huynh;
        private System.Windows.Forms.Button btnPT1_18_Huynh;
    }
}
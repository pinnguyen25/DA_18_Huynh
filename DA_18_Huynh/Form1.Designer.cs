namespace DA_18_Huynh
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
            this.OpenF1_18 = new System.Windows.Forms.Button();
            this.OpenF2_18 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenF1_18
            // 
            this.OpenF1_18.Location = new System.Drawing.Point(219, 186);
            this.OpenF1_18.Name = "OpenF1_18";
            this.OpenF1_18.Size = new System.Drawing.Size(134, 51);
            this.OpenF1_18.TabIndex = 0;
            this.OpenF1_18.Text = "Open Giải PT";
            this.OpenF1_18.UseVisualStyleBackColor = true;
            this.OpenF1_18.Click += new System.EventHandler(this.OpenF1_18_Click);
            // 
            // OpenF2_18
            // 
            this.OpenF2_18.Location = new System.Drawing.Point(431, 186);
            this.OpenF2_18.Name = "OpenF2_18";
            this.OpenF2_18.Size = new System.Drawing.Size(134, 51);
            this.OpenF2_18.TabIndex = 1;
            this.OpenF2_18.Text = "Open Web";
            this.OpenF2_18.UseVisualStyleBackColor = true;
            this.OpenF2_18.Click += new System.EventHandler(this.OpenF2_18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenF2_18);
            this.Controls.Add(this.OpenF1_18);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenF1_18;
        private System.Windows.Forms.Button OpenF2_18;
    }
}


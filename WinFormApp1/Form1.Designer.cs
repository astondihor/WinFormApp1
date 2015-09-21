namespace WinFormApp1
{
    partial class MainForm
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
            this.btnCoba = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoba
            // 
            this.btnCoba.Location = new System.Drawing.Point(477, 226);
            this.btnCoba.Name = "btnCoba";
            this.btnCoba.Size = new System.Drawing.Size(75, 23);
            this.btnCoba.TabIndex = 0;
            this.btnCoba.Text = "Coba!";
            this.btnCoba.UseVisualStyleBackColor = true;
            this.btnCoba.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apa Ini?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCoba);
            this.Name = "MainForm";
            this.Text = "Aplikasi Penggugah Selera Nusantara";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoba;
        private System.Windows.Forms.Button button1;
    }
}


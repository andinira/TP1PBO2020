namespace TP1
{
    partial class menuBaru
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
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnKtlg = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBeli
            // 
            this.btnBeli.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBeli.Location = new System.Drawing.Point(16, 26);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(109, 61);
            this.btnBeli.TabIndex = 0;
            this.btnBeli.Text = "BELI";
            this.btnBeli.UseVisualStyleBackColor = false;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnKtlg
            // 
            this.btnKtlg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKtlg.Location = new System.Drawing.Point(162, 26);
            this.btnKtlg.Name = "btnKtlg";
            this.btnKtlg.Size = new System.Drawing.Size(109, 62);
            this.btnKtlg.TabIndex = 1;
            this.btnKtlg.Text = "KATALOG";
            this.btnKtlg.UseVisualStyleBackColor = false;
            this.btnKtlg.Click += new System.EventHandler(this.btnKtlg_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.Location = new System.Drawing.Point(308, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 62);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 107);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKtlg);
            this.Controls.Add(this.btnBeli);
            this.Name = "menuBaru";
            this.Text = "Form Menu";
            this.Load += new System.EventHandler(this.menuBaru_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnKtlg;
        private System.Windows.Forms.Button btnLogout;
    }
}
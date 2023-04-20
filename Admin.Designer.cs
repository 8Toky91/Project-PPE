namespace Shop
{
    partial class Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MotPasseZT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NomUtZT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnecterBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 41;
            this.label4.Text = "Mot de passe Admin";
            // 
            // MotPasseZT
            // 
            this.MotPasseZT.Location = new System.Drawing.Point(205, 334);
            this.MotPasseZT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MotPasseZT.Name = "MotPasseZT";
            this.MotPasseZT.Size = new System.Drawing.Size(486, 31);
            this.MotPasseZT.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nom Admin";
            // 
            // NomUtZT
            // 
            this.NomUtZT.Location = new System.Drawing.Point(205, 225);
            this.NomUtZT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NomUtZT.Name = "NomUtZT";
            this.NomUtZT.Size = new System.Drawing.Size(486, 31);
            this.NomUtZT.TabIndex = 38;
            this.NomUtZT.TextChanged += new System.EventHandler(this.NomUtZT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(316, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Connexion Admin";
            // 
            // ConnecterBtn
            // 
            this.ConnecterBtn.Location = new System.Drawing.Point(373, 420);
            this.ConnecterBtn.Name = "ConnecterBtn";
            this.ConnecterBtn.Size = new System.Drawing.Size(158, 76);
            this.ConnecterBtn.TabIndex = 43;
            this.ConnecterBtn.Text = "Se connecter";
            this.ConnecterBtn.UseVisualStyleBackColor = true;
            this.ConnecterBtn.Click += new System.EventHandler(this.ConnecterBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 597);
            this.panel1.TabIndex = 81;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnecterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MotPasseZT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NomUtZT);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MotPasseZT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NomUtZT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnecterBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace Ravintolatilaus
{
    partial class LoginUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exit1 = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.PassText1 = new System.Windows.Forms.TextBox();
            this.UserText1 = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit1);
            this.groupBox1.Controls.Add(this.Loginbutton);
            this.groupBox1.Controls.Add(this.PassText1);
            this.groupBox1.Controls.Add(this.UserText1);
            this.groupBox1.Controls.Add(this.Pass);
            this.groupBox1.Controls.Add(this.User);
            this.groupBox1.Location = new System.Drawing.Point(155, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(18, 123);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(75, 23);
            this.Exit1.TabIndex = 3;
            this.Exit1.Text = "Lopeta";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(129, 123);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(75, 23);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "Kirjaudu";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // PassText1
            // 
            this.PassText1.Location = new System.Drawing.Point(114, 86);
            this.PassText1.Name = "PassText1";
            this.PassText1.Size = new System.Drawing.Size(100, 20);
            this.PassText1.TabIndex = 3;
            // 
            // UserText1
            // 
            this.UserText1.Location = new System.Drawing.Point(114, 17);
            this.UserText1.Name = "UserText1";
            this.UserText1.Size = new System.Drawing.Size(100, 20);
            this.UserText1.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(30, 86);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(51, 13);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Salasana";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(30, 20);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(63, 13);
            this.User.TabIndex = 0;
            this.User.Text = "Kayttajanimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(152, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yritys X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(185, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruokasofta";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginUI";
            this.Text = "LoginUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PassText1;
        private System.Windows.Forms.TextBox UserText1;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Exit1;
    }
}
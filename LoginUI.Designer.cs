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
            this.groupBox1.Location = new System.Drawing.Point(207, 244);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(319, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kirjautuminen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Exit1
            // 
            this.Exit1.Location = new System.Drawing.Point(26, 172);
            this.Exit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit1.Name = "Exit1";
            this.Exit1.Size = new System.Drawing.Size(100, 28);
            this.Exit1.TabIndex = 3;
            this.Exit1.Text = "Lopeta";
            this.Exit1.UseVisualStyleBackColor = true;
            this.Exit1.Click += new System.EventHandler(this.Exit1_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(186, 172);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(100, 28);
            this.Loginbutton.TabIndex = 3;
            this.Loginbutton.Text = "Kirjaudu";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // PassText1
            // 
            this.PassText1.Location = new System.Drawing.Point(141, 120);
            this.PassText1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassText1.Name = "PassText1";
            this.PassText1.Size = new System.Drawing.Size(132, 22);
            this.PassText1.TabIndex = 3;
            // 
            // UserText1
            // 
            this.UserText1.Location = new System.Drawing.Point(141, 63);
            this.UserText1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserText1.Name = "UserText1";
            this.UserText1.Size = new System.Drawing.Size(132, 22);
            this.UserText1.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(29, 120);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(67, 17);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Salasana";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(29, 66);
            this.User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(84, 17);
            this.User.TabIndex = 0;
            this.User.Text = "Kayttajanimi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(134, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lounasravintola Oy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(201, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruokatilaus";
            // 
            // LoginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 502);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
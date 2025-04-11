namespace Tiny_House_Rezervasyon_ve_Yönetim_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Navbar = new System.Windows.Forms.Label();
            this.LoginMailAdressLabel = new System.Windows.Forms.Label();
            this.LoginPasswordLabel = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginMailAdressTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterMailAdressTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(152)))));
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Navbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 12);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Navbar
            // 
            this.Navbar.AutoSize = true;
            this.Navbar.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Navbar.Location = new System.Drawing.Point(3, 9);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(201, 28);
            this.Navbar.TabIndex = 0;
            this.Navbar.Text = "Login & Registration";
            this.Navbar.Click += new System.EventHandler(this.Navbar_Click);
            // 
            // LoginMailAdressLabel
            // 
            this.LoginMailAdressLabel.AutoSize = true;
            this.LoginMailAdressLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.LoginMailAdressLabel.Location = new System.Drawing.Point(25, 175);
            this.LoginMailAdressLabel.Name = "LoginMailAdressLabel";
            this.LoginMailAdressLabel.Size = new System.Drawing.Size(134, 30);
            this.LoginMailAdressLabel.TabIndex = 1;
            this.LoginMailAdressLabel.Text = "Email Adress";
            this.LoginMailAdressLabel.Click += new System.EventHandler(this.LoginMailAdressLabel_Click);
            // 
            // LoginPasswordLabel
            // 
            this.LoginPasswordLabel.AutoSize = true;
            this.LoginPasswordLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.LoginPasswordLabel.Location = new System.Drawing.Point(25, 229);
            this.LoginPasswordLabel.Name = "LoginPasswordLabel";
            this.LoginPasswordLabel.Size = new System.Drawing.Size(104, 30);
            this.LoginPasswordLabel.TabIndex = 1;
            this.LoginPasswordLabel.Text = "Password";
            this.LoginPasswordLabel.Click += new System.EventHandler(this.LoginPasswordLabel_Click);
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(210, 231);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(172, 31);
            this.LoginPasswordTextBox.TabIndex = 2;
            this.LoginPasswordTextBox.TextChanged += new System.EventHandler(this.LoginPasswordTextBox_TextChanged);
            // 
            // LoginMailAdressTextBox
            // 
            this.LoginMailAdressTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.LoginMailAdressTextBox.Location = new System.Drawing.Point(210, 175);
            this.LoginMailAdressTextBox.Name = "LoginMailAdressTextBox";
            this.LoginMailAdressTextBox.Size = new System.Drawing.Size(172, 31);
            this.LoginMailAdressTextBox.TabIndex = 2;
            this.LoginMailAdressTextBox.TextChanged += new System.EventHandler(this.LoginMailAdressTextBox_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(204)))), ((int)(((byte)(236)))));
            this.LoginButton.Location = new System.Drawing.Point(32, 282);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Padding = new System.Windows.Forms.Padding(2);
            this.LoginButton.Size = new System.Drawing.Size(127, 42);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(431, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Register";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(204)))), ((int)(((byte)(236)))));
            this.RegisterButton.Location = new System.Drawing.Point(440, 282);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Padding = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Size = new System.Drawing.Size(127, 42);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterMailAdressTextBox
            // 
            this.RegisterMailAdressTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.RegisterMailAdressTextBox.Location = new System.Drawing.Point(618, 175);
            this.RegisterMailAdressTextBox.Name = "RegisterMailAdressTextBox";
            this.RegisterMailAdressTextBox.Size = new System.Drawing.Size(172, 31);
            this.RegisterMailAdressTextBox.TabIndex = 7;
            this.RegisterMailAdressTextBox.TextChanged += new System.EventHandler(this.RegisterMailAdressTextBox_TextChanged);
            // 
            // RegisterPasswordTextBox
            // 
            this.RegisterPasswordTextBox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.RegisterPasswordTextBox.Location = new System.Drawing.Point(618, 231);
            this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            this.RegisterPasswordTextBox.Size = new System.Drawing.Size(172, 31);
            this.RegisterPasswordTextBox.TabIndex = 8;
            this.RegisterPasswordTextBox.TextChanged += new System.EventHandler(this.RegisterPasswordTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(433, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(433, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Adress";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(396, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 381);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(204)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RegisterMailAdressTextBox);
            this.Controls.Add(this.RegisterPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginMailAdressTextBox);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.LoginPasswordLabel);
            this.Controls.Add(this.LoginMailAdressLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login & Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Navbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LoginMailAdressLabel;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.TextBox LoginMailAdressTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox RegisterMailAdressTextBox;
        private System.Windows.Forms.TextBox RegisterPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}


namespace BUILD
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label_autorization = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_autorization
            // 
            this.label_autorization.BackColor = System.Drawing.Color.Transparent;
            this.label_autorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_autorization.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_autorization.Location = new System.Drawing.Point(0, 0);
            this.label_autorization.Name = "label_autorization";
            this.label_autorization.Size = new System.Drawing.Size(301, 52);
            this.label_autorization.TabIndex = 0;
            this.label_autorization.Text = "Авторизация";
            this.label_autorization.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_login
            // 
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_login.Location = new System.Drawing.Point(12, 58);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(100, 23);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_password.Location = new System.Drawing.Point(12, 119);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(123, 27);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_login.Location = new System.Drawing.Point(12, 84);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(277, 30);
            this.textBox_login.TabIndex = 3;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox_password.Location = new System.Drawing.Point(12, 145);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(277, 30);
            this.textBox_password.TabIndex = 4;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(12, 191);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(96, 27);
            this.button_input.TabIndex = 5;
            this.button_input.Text = "вход";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(114, 191);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(175, 27);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "зарегестрироваться";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_message
            // 
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(12, 224);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(277, 23);
            this.label_message.TabIndex = 7;
            // 
            // StartForm
            // 
            this.AcceptButton = this.button_input;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(301, 256);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_autorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТРОЙ!";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_message;

        private System.Windows.Forms.Button button_register;

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_input;

        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_autorization;

        #endregion
    }
}
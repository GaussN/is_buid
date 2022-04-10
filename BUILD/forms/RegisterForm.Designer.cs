using System.ComponentModel;

namespace BUILD
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password_1 = new System.Windows.Forms.Label();
            this.label_password_2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password_1 = new System.Windows.Forms.TextBox();
            this.textBox_password_2 = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.label_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label_name.Location = new System.Drawing.Point(12, 10);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(277, 23);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Имя";
            // 
            // label_surname
            // 
            this.label_surname.BackColor = System.Drawing.Color.Transparent;
            this.label_surname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label_surname.Location = new System.Drawing.Point(12, 70);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(277, 23);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "Фамилия";
            // 
            // label_login
            // 
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label_login.Location = new System.Drawing.Point(12, 131);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(277, 23);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Логин";
            // 
            // label_password_1
            // 
            this.label_password_1.BackColor = System.Drawing.Color.Transparent;
            this.label_password_1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_password_1.Location = new System.Drawing.Point(12, 192);
            this.label_password_1.Name = "label_password_1";
            this.label_password_1.Size = new System.Drawing.Size(277, 23);
            this.label_password_1.TabIndex = 3;
            this.label_password_1.Text = "Пароль";
            // 
            // label_password_2
            // 
            this.label_password_2.BackColor = System.Drawing.Color.Transparent;
            this.label_password_2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_password_2.Location = new System.Drawing.Point(12, 253);
            this.label_password_2.Name = "label_password_2";
            this.label_password_2.Size = new System.Drawing.Size(277, 23);
            this.label_password_2.TabIndex = 4;
            this.label_password_2.Text = "Повторите пароль";
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_name.Location = new System.Drawing.Point(12, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(277, 30);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_surname
            // 
            this.textBox_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_surname.Location = new System.Drawing.Point(12, 96);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(277, 30);
            this.textBox_surname.TabIndex = 6;
            // 
            // textBox_login
            // 
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_login.Location = new System.Drawing.Point(12, 157);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(277, 30);
            this.textBox_login.TabIndex = 7;
            // 
            // textBox_password_1
            // 
            this.textBox_password_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_password_1.Location = new System.Drawing.Point(12, 218);
            this.textBox_password_1.Name = "textBox_password_1";
            this.textBox_password_1.Size = new System.Drawing.Size(277, 30);
            this.textBox_password_1.TabIndex = 8;
            this.textBox_password_1.UseSystemPasswordChar = true;
            // 
            // textBox_password_2
            // 
            this.textBox_password_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_password_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_password_2.Location = new System.Drawing.Point(12, 279);
            this.textBox_password_2.Name = "textBox_password_2";
            this.textBox_password_2.Size = new System.Drawing.Size(277, 30);
            this.textBox_password_2.TabIndex = 9;
            this.textBox_password_2.UseSystemPasswordChar = true;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(12, 345);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(277, 27);
            this.button_register.TabIndex = 10;
            this.button_register.Text = "Регистация";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.Location = new System.Drawing.Point(12, 315);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(277, 24);
            this.checkBox_show_password.TabIndex = 11;
            this.checkBox_show_password.Text = "показать пароль";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // label_message
            // 
            this.label_message.BackColor = System.Drawing.Color.Transparent;
            this.label_message.ForeColor = System.Drawing.Color.Red;
            this.label_message.Location = new System.Drawing.Point(12, 375);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(277, 28);
            this.label_message.TabIndex = 12;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(301, 408);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password_2);
            this.Controls.Add(this.textBox_password_1);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_password_2);
            this.Controls.Add(this.label_password_1);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "СТРОЙ! Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label_message;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.CheckBox checkBox_show_password;

        private System.Windows.Forms.Button button_register;

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password_1;
        private System.Windows.Forms.TextBox textBox_password_2;

        private System.Windows.Forms.Label label_password_1;
        private System.Windows.Forms.Label label_password_2;
        private System.Windows.Forms.Label label_login;

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;

        #endregion
    }
}
using System;
using System.Windows.Forms;
using BUILD.modules;

namespace BUILD
{
    public partial class RegisterForm : Form
    {
        private const string NameFieldEmpty = "Поле имени не должен быть пустым";
        private const string SurnameFieldEmpty = "Поле фамилии не должно быть пустым";
        private const string LoginFieldEmpty = "Поле логина не должно быть пустым";
        private const string PasswordFieldEmpty = "Поле пароля не должно быть пустым";
        private const string PasswordDontMatch= "Пароли не совпадают";
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_password.Checked)
            {
                textBox_password_1.UseSystemPasswordChar = false;
                textBox_password_2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password_1.UseSystemPasswordChar = true;
                textBox_password_2.UseSystemPasswordChar = true;
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                
                string name, surname, login, password;
                if ((name = textBox_name.Text.Trim()) == String.Empty)
                {
                    label_message.Text = NameFieldEmpty;
                    return;
                }
                if ((surname = textBox_surname.Text.Trim()) == String.Empty)
                {
                    label_message.Text = SurnameFieldEmpty;
                    return;
                }
                if ((login = textBox_login.Text.Trim()) == String.Empty)
                {
                    label_message.Text = LoginFieldEmpty;
                    return;
                }
                if ((password = textBox_password_1.Text.Trim()) == String.Empty)
                {
                    label_message.Text = PasswordFieldEmpty;
                    return;
                }
                if (password != textBox_password_2.Text.Trim())
                {
                    label_message.Text = PasswordDontMatch;
                    return;
                }

                User user = new User() { name=name, surname = surname, rights = false};
                RegistrationService.RegisterUser(user, login, password);

            }
            catch (Exception exception)
            { 
                MessageBox.Show($"Ошибка регистрации\n{exception.Message}", "Люди!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"Регистрация прошла успешно");
            this.Close();
        }
    }
}
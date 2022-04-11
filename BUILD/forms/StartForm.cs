using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUILD.modules;

namespace BUILD
{
    public partial class StartForm : Form
    {
        private const string LoginFieldEmptyWarning = "поле логина не должно быть пустым";
        private const string PasswordFieldEmptyWarning = "поле пароля не должно быть пустым";
        private const string WrongLoginOrPasswordWarning = "неверный логин или пароль";

        public StartForm()
        {
            InitializeComponent();
            //на потом
            // var colorService = new ColorService();
            // colorService.UpdateColor(this);

        }

        private void button_input_Click(object sender, EventArgs e)
        {
            try
            {
                //получение введенных данных 
                var login = textBox_login.Text.Trim();
                var password = textBox_password.Text.Trim();
            
                //проверка ввода
                //ErrorProvide для слабых
                if (login == "")
                    label_message.Text = LoginFieldEmptyWarning;
                else if (password == String.Empty)
                    label_message.Text = PasswordFieldEmptyWarning;
                else
                {

                    //авторизация
                    var user = AutorizationService.UserAutorization(login: login, password: password);
                    if (user.id == -1)
                    {
                        label_message.Text = WrongLoginOrPasswordWarning;
                        return;
                    }

                    label_message.Text = String.Empty;
                
                    this.Hide();
                    (new AdminForm(user, this)).Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка в авторизации\n{exception.Message}", "Люди!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            var regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
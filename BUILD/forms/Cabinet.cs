using System;
using System.Windows.Forms;
using BUILD.modules;
using Microsoft.Office.Interop.Word;
using MySqlConnector;

namespace BUILD
{
    public partial class Cabinet : Form
    {
        private const string NameFieldEmpty = "Поле имени не должен быть пустым";
        private const string SurnameFieldEmpty = "Поле фамилии не должно быть пустым";
        private const string LoginFieldEmpty = "Поле логина не должно быть пустым";
        private const string PasswordFieldEmpty = "Поле пароля не должно быть пустым";
        private const string PasswordDontMatch= "Пароли не совпадают";

        private AdminForm _form;
        //private User _user;
        private string _login;
        private string _pasword;
        
        public Cabinet(AdminForm form)
        {
            InitializeComponent();
            this._form = form;
            
            
            this.textBox_name.Text = _form._user.name;
            this.textBox_surname.Text = _form._user.surname;

            try
            {
                
                DB db = new DB();
                string cmd = $"select user_login, user_password from autorization_data where user_id={_form._user.id};";
                MySqlCommand command = new MySqlCommand(cmd, db.GetConnection());
                var reader = command.ExecuteReader();
                reader.Read();
                this._login = reader[0].ToString().Trim();
                this._pasword = reader[1].ToString().Trim();

                this.textBox_login.Text = this._login;
                this.textBox_password_1.Text = this._pasword;
                this.textBox_password_2.Text = this._pasword;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при получении данных");
            }


        }
        

        private void button_register_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.textBox_name.Text.Trim();
                string surname = this.textBox_surname.Text.Trim();
                string login = this.textBox_login.Text.Trim();
                string password;
                if (String.IsNullOrEmpty(name))
                {
                    //this.label1.Text = NameFieldEmpty;
                    MessageBox.Show(NameFieldEmpty);
                    return;
                }
    
                if (String.IsNullOrEmpty(surname))
                {
                    //this.label1.Text = SurnameFieldEmpty;
                    MessageBox.Show(SurnameFieldEmpty);
                    return;
                }
    
                if (String.IsNullOrEmpty(login))
                {
                    //this.label1.Text = LoginFieldEmpty;
                    MessageBox.Show(LoginFieldEmpty);
                    return;
                }
    
                if (String.IsNullOrEmpty(this.textBox_password_1.Text.Trim()))
                {
                    //this.label1.Text = PasswordFieldEmpty;
                    MessageBox.Show(PasswordFieldEmpty);
                    return;
                }
    
                if (this.textBox_password_1.Text.Trim() != this.textBox_password_2.Text.Trim())
                {
                    //this.label1.Text = PasswordDontMatch;
                    MessageBox.Show(PasswordDontMatch);
                    return;
                }
                
                password = this.textBox_password_1.Text.Trim();
                string cmd1 = $"UPDATE autorization_data SET user_login=\'{login}\', user_password=\'{password}\' WHERE user_id={_form._user.id}";
                string cmd2 = $"UPDATE users_data SET user_name=\'{name}\', user_surname=\'{surname}\' WHERE user_id={_form._user.id}";
                DB db = new DB();
                MySqlCommand command1 = new MySqlCommand(cmd1, db.GetConnection());
                MySqlCommand command2 = new MySqlCommand(cmd2, db.GetConnection());
                command1.ExecuteScalar();
                command2.ExecuteScalar();

                _form._user.name = name;
                _form._user.surname = surname;

                MessageBox.Show("Изменения сохранены");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка при изменении данных\n" + exception.Message);
            }
            
        }

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_password_2.UseSystemPasswordChar = 
                this.textBox_password_1.UseSystemPasswordChar = 
                    !checkBox_show_password.Checked;
        }

        private void bEx_Click(object sender, EventArgs e)
        {
            //this.Close();
        }
    }
}
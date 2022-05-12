using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules.objects
{
    public partial class UChangeForm : Form
    {
        public UChangeForm(User user)
        {
            InitializeComponent();
            this.textBox_id.Text = user.Id.ToString();
            this.textBox_name.Text = user.Name;
            this.textBox_surname.Text = user.Surname;
            this.checkBox_admin.Checked = user.Right;
        }

        private string buildRequest(User user)
        {
            return
                $"UPDATE users_data SET user_name=\'{user.Name}\', user_surname=\'{user.Surname}\', user_rights={ (user.Right ? 1 : 0) } where user_id={user.Id}";
        }

        private void UpdateEntry(User user)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(buildRequest(user), db.GetConnection());
            command.ExecuteReader();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(textBox_name) != String.Empty)
                return;
            if (errorProvider2.GetError(textBox_surname) != String.Empty)
                return;
            User user = new User(
                int.Parse(textBox_id.Text),
                textBox_name.Text,
                textBox_surname.Text,
                checkBox_admin.Checked
            );

            this.UpdateEntry(user);
            
            this.Close();
        }
        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox_name.Text.Trim()))
                this.errorProvider1.SetError(this.textBox_name, "пустое поле имени");
            else if (this.textBox_name.Text.Trim().Length < 2)
                this.errorProvider1.SetError(this.textBox_name, "слишком короткое имя");
            else
                this.errorProvider1.Clear();
        }

        private void textBox_surname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox_surname.Text.Trim()))
                this.errorProvider2.SetError(this.textBox_surname, "пустое поле фамилии");
            else if (this.textBox_surname.Text.Trim().Length < 2)
                this.errorProvider2.SetError(this.textBox_surname, "слишком короткая фамилия");
            else
                this.errorProvider2.Clear();
        }

        private void checkBox_admin_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
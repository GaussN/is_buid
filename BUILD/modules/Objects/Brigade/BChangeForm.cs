using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules.objects
{
    public partial class BChangeForm : Form
    {
        public BChangeForm(Brigade brigade)
        {
            InitializeComponent();

            this.textBox1.Text = brigade.Id.ToString();
            this.textBox2.Text = brigade.IdBrigadier.ToString();
            this.textBox3.Text = brigade.Name;
            this.textBox4.Text = brigade.Surname;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox3.Text.Trim()))
                this.errorProvider1.SetError(this.textBox3, "пустое поле имени");
            else if (this.textBox3.Text.Trim().Length < 2)
                this.errorProvider1.SetError(this.textBox3, "слишком короткое имя");
            else
                this.errorProvider1.Clear();
        }

        private string buildRequest(Brigade brigade)
        {
            return
                $"UPDATE brigadiers SET brigadier_name=\'{brigade.Name}\', brigadier_surname=\'{brigade.Surname}\' where brigadier_id={brigade.IdBrigadier}";
        }

        private void UpdateEntry(Brigade brigade)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(buildRequest(brigade), db.GetConnection());
            command.ExecuteReader();
        }
        
        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox4.Text.Trim()))
                this.errorProvider2.SetError(this.textBox4, "пустое поле фамилии");
            else if (this.textBox4.Text.Trim().Length < 2)
                this.errorProvider2.SetError(this.textBox4, "слишком короткая фамилия");
            else
                this.errorProvider2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(textBox3) != String.Empty)
                return;
            if (errorProvider2.GetError(textBox4) != String.Empty)
                return;
            
            Brigade b = new Brigade(
                int.Parse(textBox1.Text.Trim()),
                int.Parse(textBox2.Text.Trim()),
                textBox3.Text.Trim(),
                textBox4.Text.Trim()
            );
            
            UpdateEntry(b);
            
            this.Close(); 
        }
    }
}
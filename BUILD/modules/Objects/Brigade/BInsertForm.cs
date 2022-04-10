using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUILD.modules.objects
{
    public partial class BInsertForm : Form
    {
        public BInsertForm()
        {
            InitializeComponent();

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
                $"INSERT INTO brigadiers(brigadier_name, brigadier_surname) VALUES(\'{brigade.Name}\', \'{brigade.Surname}\');\nINSERT INTO brigades(brigadier_id) VALUES()";
        }

        private void UpdateEntry(Brigade brigade)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand(buildRequest(brigade), db.GetConnection());
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
                -1, -1,
                textBox3.Text.Trim(),
                textBox4.Text.Trim()
            );
            
            UpdateEntry(b);
            
            this.Close(); 
        }
    }
}
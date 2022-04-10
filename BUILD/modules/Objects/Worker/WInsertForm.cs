using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUILD.modules.objects
{
    public partial class WInsertForm : Form
    {
        public WInsertForm(Worker worker)
        {
            InitializeComponent();

            string cmd = "SELECT brigade_id FROM brigades";
            DB db = new DB();
            SqlCommand command = new SqlCommand(cmd, db.GetConnection());
            try
            {
                var rider = command.ExecuteReader();
                while (rider.Read())
                {
                    comboBox1.Items.Add(rider.GetValue(0).ToString());
                }
            }
            catch
            {
                // ignored
            }

            //this.comboBox1.Text = worker.IdBrigade.ToString();
            this.comboBox1.Text = this.comboBox1.Items[0].ToString();
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_name.Text.Trim()))
                errorProvider1.SetError(textBox_name, "Пустое имя");
            else if (textBox_name.Text.Trim().Length < 2)
                errorProvider1.SetError(textBox_name, "Слишком короткое имя");
            else 
                errorProvider1.Clear();
                
        }
        private void textBox_surname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_surname.Text.Trim()))
                errorProvider2.SetError(textBox_surname, "Пустое имя");
            else if (textBox_surname.Text.Trim().Length < 2)
                errorProvider2.SetError(textBox_surname, "Слишком короткое имя");
            else 
                errorProvider2.Clear();
        }

        private void textBox_speciality_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_speciality.Text.Trim()))
                errorProvider3.SetError(textBox_speciality, "Пустое имя");
            else if (textBox_speciality.Text.Trim().Length < 2)
                errorProvider3.SetError(textBox_speciality, "Слишком короткое имя");
            else 
                errorProvider3.Clear();
        }
        private string buildRequest(Worker w)
        {
            return
                $"INSERT INTO workers(brigade_id, worker_name, worker_surname, worker_speciality, worker_lvl) VALUES({w.IdBrigade}, \'{w.Name}\', \'{w.Surname}\', \'{w.Speciality}\', {w.Lvl})";
        }
        private void UpdateEntry(Worker w)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand(buildRequest(w), db.GetConnection());
            command.ExecuteReader();
        }
        private void button_change_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(textBox_name) != String.Empty)
                return;
            if (errorProvider2.GetError(textBox_surname) != String.Empty)
                return;
            if (errorProvider3.GetError(textBox_speciality) != String.Empty)
                return;
            Worker w = new Worker
            (
                    -1,
                int .Parse(this.comboBox1.Text),
                textBox_name.Text.Trim(),
                textBox_surname.Text.Trim(),
                textBox_speciality.Text.Trim(),
                Convert.ToInt32(numericUpDown_lvl.Value)
            );

            this.UpdateEntry(w);

            this.Close();

        }
    }
}
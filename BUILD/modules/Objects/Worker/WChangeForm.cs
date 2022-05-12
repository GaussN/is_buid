using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules.objects
{
    public partial class WChangeForm : Form
    {
        public WChangeForm(Worker worker)
        {
            InitializeComponent();

            string cmd = "SELECT brigade_id FROM brigades";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(cmd, db.GetConnection());
            try
            {
                var rider = command.ExecuteReader();
                while (rider.Read())
                {
                    comboBox1.Items.Add(rider.GetValue(0).ToString());
                }
                comboBox1.Items.Add("-");
                comboBox1.SelectedIndex = 0;
            }
            catch
            {
                // ignored
            }

            this.textBox_id.Text = worker.Id.ToString();
            //this.comboBox1.Text = (worker.IdBrigade != -1 ?worker.IdBrigade:'-').ToString();
            this.textBox_name.Text = worker.Name;
            this.textBox_surname.Text = worker.Surname;
            this.textBox_speciality.Text = worker.Speciality;
            this.numericUpDown_lvl.Value = Convert.ToDecimal(worker.Lvl);
            
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_name.Text.Trim()))
                errorProvider1.SetError(textBox_name, "Пустое поле");
            else if (textBox_name.Text.Trim().Length < 2)
                errorProvider1.SetError(textBox_name, "Слишком короткое поле");
            else 
                errorProvider1.Clear();
                
        }
        private void textBox_surname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_surname.Text.Trim()))
                errorProvider2.SetError(textBox_surname, "Пустое поле");
            else if (textBox_surname.Text.Trim().Length < 2)
                errorProvider2.SetError(textBox_surname, "Слишком короткое поле");
            else 
                errorProvider2.Clear();
        }

        private void textBox_speciality_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_speciality.Text.Trim()))
                errorProvider3.SetError(textBox_speciality, "Пустое поле");
            else if (textBox_speciality.Text.Trim().Length < 2)
                errorProvider3.SetError(textBox_speciality, "Слишкое короткое поле");
            else 
                errorProvider3.Clear();
        }
        private string buildRequest(Worker w)
        {
            if (w.IdBrigade == -1)
                return $"UPDATE workers SET brigade_id=NULL, worker_name=\'{w.Name}\', worker_surname=\'{w.Surname}\', worker_speciality=\'{w.Speciality}\', worker_lvl={w.Lvl} WHERE worker_id={w.Id}";
            return
                $"UPDATE workers SET brigade_id={w.IdBrigade}, worker_name=\'{w.Name}\', worker_surname=\'{w.Surname}\', worker_speciality=\'{w.Speciality}\', worker_lvl={w.Lvl} WHERE worker_id={w.Id}";
        }
        private void UpdateEntry(Worker w)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(buildRequest(w), db.GetConnection());
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
                int.Parse(textBox_id.Text),
                int .Parse(this.comboBox1.Text != "-" ? this.comboBox1.Text : "-1"),
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
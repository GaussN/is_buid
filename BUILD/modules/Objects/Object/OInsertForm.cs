using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;

namespace BUILD.modules.objects
{
    public partial class OInsertForm : Form
    {
        public OInsertForm()
        {
            InitializeComponent();
            try
            {
                string cmd = "SELECT user_id FROM users_data WHERE user_rights=0";
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(cmd, db.GetConnection());
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.comboBox_id_user.Items.Add(reader[0].ToString());
                    }
                }
                this.comboBox1.Items.Add("-");
                cmd = "SELECT brigade_id FROM brigades";
                command = new MySqlCommand(cmd, db.GetConnection());
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.comboBox1.Items.Add(reader[0].ToString());
                    }
                }


                this.comboBox_id_user.SelectedIndex = 0;
                this.comboBox1.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка SQL\n{e.Message}");
                this.Close();
            }


        }

        private void textBox_title_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_title.Text.Trim()))
                errorProvider1.SetError(textBox_title, "Пустое поле");
            else if (textBox_title.Text.Trim().Length < 6)
                errorProvider1.SetError(textBox_title, "Слишком короткое значение");
            else
                errorProvider1.Clear();
        }
        private string buildRequest(Object o)
        {
            if (o.IdBrigade == -1)
                return $"INSERT INTO objects_data(object_name, user_id, brigade_id, object_area, state) VALUES(\'{o.Title}\', {o.IdUser}, NULL, {o.Area}, \'{o.State}\')";
            return $"INSERT INTO objects_data(object_name, user_id, brigade_id, object_area, state) VALUES(\'{o.Title}\', {o.IdUser}, {o.IdBrigade}, {o.Area}, \'{o.State}\')";
        }
        private void UpdateEntry(Object o)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(buildRequest(o), db.GetConnection());
            command.ExecuteReader();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(errorProvider1.GetError(textBox_title).Trim()))
            {
                return;   
            }
            
            var area = .0;
            double.TryParse(textBox_area.Text, out area);
            Object obj = new Object(
                -1,
                textBox_title.Text.Trim(),
                int.Parse(comboBox_id_user.Text.Trim()),
                int.Parse(this.comboBox1.Text != "-" ? this.comboBox1.Text : "-1"),
                area,
                textBox_state.Text);

            this.UpdateEntry(obj);

            this.Close();
        }

        private void textBox_area_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_area.Text.Trim()))
                errorProvider2.SetError(textBox_area, "Пустое полу");
            else
                    errorProvider2.Clear();
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
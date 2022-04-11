using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUILD.modules.objects
{
    public partial class OChangeForm : Form
    {
        public OChangeForm(Object obj)
        {
            InitializeComponent();
            this.textBox_id.Text = obj.Id.ToString();
            this.textBox_title.Text = obj.Title;
            this.textBox_state.Text = obj.State;
            this.comboBox1.Items.Add("-");
            try
            {
                string cmd = "SELECT user_id FROM users_data WHERE user_rights=0";
                DB db = new DB();
                SqlCommand command = new SqlCommand(cmd, db.GetConnection());
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.comboBox_id_user.Items.Add(reader[0].ToString());
                    }
                }

                cmd = "SELECT brigade_id FROM brigades";
                command = new SqlCommand(cmd, db.GetConnection());
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        this.comboBox1.Items.Add(reader[0].ToString());
                    }
                }
                this.comboBox_id_user.SelectedItem = obj.IdUser.ToString();
                this.comboBox1.Text = obj.IdBrigade == -1 ? "-" : obj.IdBrigade.ToString();
                this.textBox_area.Text = obj.Area.ToString();

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка SQL\n{e.Message}");
                this.Close();
            }


        }

        private void textBox_title_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_title.Text))
                errorProvider1.SetError(textBox_title, "Пустое поле");
            else if (textBox_title.Text.Trim().Length < 6)
                errorProvider1.SetError(textBox_title, "Слишком короткое значение");
            else
                errorProvider1.Clear();
        }
        private string buildRequest(Object o)
        {
            if (o.IdBrigade==-1)
                return $"UPDATE objects_data SET object_name=\'{o.Title}\', user_id={o.IdUser}, brigade_id=NULL, object_area={o.Area}, state=\'{o.State}\' WHERE object_id={o.Id}";
            return
                        $"UPDATE objects_data SET object_name=\'{o.Title}\', user_id={o.IdUser}, brigade_id={o.IdBrigade}, object_area={o.Area}, state=\'{o.State}\' WHERE object_id={o.Id}";
        }
        private void UpdateEntry(Object o)
        {
            DB db = new DB();
            SqlCommand command = new SqlCommand(buildRequest(o), db.GetConnection());
            command.ExecuteReader();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(errorProvider2.GetError(textBox_area)) && String.IsNullOrEmpty(errorProvider1.GetError(textBox_title)))
            {
                Object obj = new Object(
                    int.Parse(textBox_id.Text.Trim()),
                    textBox_title.Text.Trim(),
                    int.Parse(comboBox_id_user.Text.Trim()),
                    int .Parse(this.comboBox1.Text != "-" ? this.comboBox1.Text : "-1"),
                    double.Parse(textBox_area.Text.Trim()),
                    textBox_state.Text
                    );
                
                this.UpdateEntry(obj);

                this.Close();
            }
        }

        private void textBox_area_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_area.Text.Trim() != String.Empty)
            {
                double x;
                if (!double.TryParse(textBox_area.Text, out x))
                    errorProvider2.SetError(textBox_area, "Неверный формат");
                else
                    errorProvider2.Clear();
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
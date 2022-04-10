using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using BUILD.modules;
using BUILD.modules.objects;
using BUILD.modules.Objects;
using BUILD.Properties;
//using User = BUILD.modules.User;

namespace BUILD
{
    public partial class AdminForm : Form
    {
        private Form _form;
        private BUILD.modules.User _user;
        private TableService _tableService;
        private Iasd _nowTable;//активная таблица
        public AdminForm(modules.User user, Form form)
        {
            InitializeComponent();
            
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.ReadOnly = true;
            штукатуркаToolStripMenuItem.Enabled = false;
            штукатуркаToolStripMenuItem.Visible = false;
            
            this._form = form;
            this._user = user;
            this._tableService = new TableService(this._user);
            
            this.button_add.Enabled = false;
            this.button_change.Enabled = false;
            this.button_delete.Enabled = false;
            if (!_user.rights)
            {
                this.button_add.Visible = false;
                this.button_change.Visible = false;
                this.button_delete.Visible = false;
                this.пользователиToolStripMenuItem.Visible = false;
                this.пользователиToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.отчетОToolStripMenuItem.Enabled = false;
                this.датьДенягToolStripMenuItem.Enabled = false;
                this.датьДенягToolStripMenuItem.Visible = false;
            }


            // Random random = new Random();
            // if (random.Next(0, 1000) == 453)
            // {
            //     MessageBox.Show("У вас СПИД");
            // }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИС \"СТРОЙ!\" v1.0.0 \nРазработал Лапцевич Н 44тп");
        }

        #region tooStripMenu 1

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._form.Close();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._form.Visible = true;
            this.Close();
        }
        

        #endregion
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._form.Visible = true;
        }

        #region [Функции ToolStripMenu]
        private void датьДенягToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ForMoney()).ShowDialog();
        }

        private void штукатуркаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var options = new ColorSettings();
            options.ShowDialog();
            (new ColorDialog()).ShowDialog();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //да, это магические табуляции, и что вы мне сделаете? 
            String info = $"ID: \t\t{_user.id}\n" +
                          $"Имя: \t\t{_user.name}\n" + 
                          $"Фамилия:\t{_user.surname}\n" + 
                          $"Админ: \t\t{_user.rights}";
            MessageBox.Show(info, "Информация");
        }

        #region tables

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button_add.Enabled = false;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;

            this._nowTable = new modules.objects.User(-1, "", "", false);
            
            this._tableService.FillUserTable(this.dataGridView);
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Worker(-1, -1, "","", "", 0);
            
            this._tableService.FillWorkersTable(this.dataGridView);
        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Brigade(-1,-1,"","");
            this._tableService.FillBrigadesTable(this.dataGridView);
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Object();
            this._tableService.FillObjectsTable(this.dataGridView);
        }

        #endregion
        #endregion
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"cell[{e.RowIndex},{e.ColumnIndex}]");
            //asd
        }

        #region [функции кнопок боковой панели]
        private void button_search_Click(object sender, EventArgs e)
        {
            
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView.Rows[this.dataGridView.CurrentCell.RowIndex];
            _nowTable.Change(row);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var row = this.dataGridView.Rows[this.dataGridView.CurrentCell.RowIndex];
            _nowTable.Delete(row);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _nowTable.Insert();
        }
        #endregion
    }
}
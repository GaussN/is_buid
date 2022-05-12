using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using BUILD.modules;
using BUILD.modules.Objects;
using MySqlConnector;
using exportWord = Microsoft.Office.Interop.Word;

namespace BUILD
{
    public partial class AdminForm : Form
    {
        private Form _form;
        private modules.User _user;
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
                this.Text = $"СТРОЙ! Пользователь";
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
            MessageBox.Show("ИС \"СТРОЙ!\" v1.0.0 \nРазработал Воробьёв Н 44тп");
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
            this.statusBar.Text = $"Таблица: Пользователи";
            
            this.button_add.Enabled = false;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;

            this._nowTable = new modules.objects.User(-1, "", "", false);
            
            this._tableService.FillUserTable(this.dataGridView);
        }

        private void работникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusBar.Text = $"Таблица: Работники";
            
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Worker(-1, -1, "","", "", 0);
            
            this._tableService.FillWorkersTable(this.dataGridView);
        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusBar.Text = $"Таблица: Бригады";
            
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Brigade(-1,-1,"","");
            this._tableService.FillBrigadesTable(this.dataGridView);
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusBar.Text = $"Таблица: Объекты";   
            
            this.button_add.Enabled = true;
            this.button_change.Enabled = true;
            this.button_delete.Enabled = true;
            this.button_search.Enabled = true;
            this._nowTable = new modules.objects.Object(-1, "", -1, -1, 0f, "");
            this._tableService.FillObjectsTable(this.dataGridView);
        }

        #endregion
        #endregion
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Хули тыкаешь?");
        }

        #region [функции кнопок боковой панели]
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                var searchForm = new SearchForm(this.dataGridView.ColumnCount - 1);
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView.ClearSelection();
                    var searchString = searchForm.ReturnValueSearchString.Trim();
                    var searchColumn = searchForm.ReturnValueSearchColumn - 1;
                    int костыль = searchColumn == -1 ? dataGridView.ColumnCount : searchColumn;
                    if (searchColumn == -1)
                    {
                        searchColumn = 0;
                        костыль = dataGridView.ColumnCount;
                    }
                    else
                        костыль = searchColumn + 1;

                    //это пизда, а не поиск
                    for (int i = 0; i < dataGridView.RowCount; i++)
                    {
                        //dataGridView.Rows[i].Selected = false;
                        for (int j = searchColumn; j < костыль; j++)
                        {
                            if (dataGridView.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridView.Rows[i].Cells[j].Value.ToString().Trim().Contains(searchString))
                                {
                                    dataGridView.Rows[i].Selected = true;
                                    break;
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Ошибка в функции поиска\n{excp.Message}", "Люди!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            try
            {
                var row = this.dataGridView.Rows[this.dataGridView.CurrentCell.RowIndex];
                _nowTable.Change(row);
                _nowTable.Update(this._tableService, this.dataGridView);
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Ошибка в функции редактирования\n{excp.Message}", "Бля, маслину поймал!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = this.dataGridView.Rows[this.dataGridView.CurrentCell.RowIndex];
                _nowTable.Delete(row);
                _nowTable.Update(this._tableService, this.dataGridView);
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Ошибка в функции удаления\n{excp.Message}", "Чики брики!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                _nowTable.Insert();
                _nowTable.Update(this._tableService, this.dataGridView);
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Ошибка в функции добавления\n{excp.Message}", "АААААААА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Reports

        private MySqlDataReader executeRequest(string req)
        {
            try
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(req, db.GetConnection());
                return command.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Во время выполнения запроса произошла ошика", "парапарапара", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private string MakeAmericaGreateAgain()
        {
            string getObjectsCount = $"select count(*) from objects_data where user_id={_user.id}";
            string getBrigadesCount = $"select count(distinct brigade_id) from objects_data where user_id={_user.id}";
            string getWorkerCount = $"select count(*) from workers where brigade_id in (select brigade_id from objects_data where user_id={_user.id})";
            
            string report = String.Empty;

            int objCount = 0;
            int brgCount = 0;
            int wkrCount = 0;
            
            var reader = executeRequest(getObjectsCount);
            if (reader != null)
            {
                reader.Read();
                objCount = int.Parse(reader[0].ToString());
            }
            reader = executeRequest(getBrigadesCount);
            if (reader != null)
            {
                reader.Read();
                brgCount = int.Parse(reader[0].ToString());
            }
            reader = executeRequest(getWorkerCount);
            if (reader != null)
            {
                reader.Read();
                wkrCount = int.Parse(reader[0].ToString());
            }
            
            report += $"{_user.name} {_user.surname}\n";
            report += $"id в системе {_user.id}\n\n";
            report += $"Инофрмация о строительных объектах\n";
            report += $"Общее количество объектов: {objCount}\n";
            report += $"Общее количество бригад: {brgCount}\n";
            report += $"Общее количество рабочих: {wkrCount}\n";
            
            
            return report;
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ReportForm(MakeAmericaGreateAgain())).ShowDialog();
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.CreatePrompt = true;
                fileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    using (StreamWriter writer = new StreamWriter(fileName))
                        writer.Write(MakeAmericaGreateAgain());
                    }
            }
            catch (Exception exception)
            {
                MessageBox.Show("При создании отчета возникла ошибка:\n" + exception.Message);
            }
        }

        private void принтерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("DEBUG PRINT");
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (send, ex) => {
                        ex.Graphics.DrawString(MakeAmericaGreateAgain(), new Font("Arial", 14), Brushes.Black, 0, 0);
                    }
                    ;
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDialog.Document.Print(); 

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void docxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                exportWord.Application wordapp = new exportWord.Application();
                wordapp.Visible = true;
                exportWord.Document worddoc;
                object wordobj = System.Reflection.Missing.Value;
                worddoc = wordapp.Documents.Add(ref wordobj);
                wordapp.Selection.TypeText(MakeAmericaGreateAgain());
                wordapp = null;
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        #endregion

        private void действияToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void statusBar_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {
            MessageBox.Show("Чего ты добиваешься?");
        }

        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Cabinet(this._user)).ShowDialog();
        }
    }
}
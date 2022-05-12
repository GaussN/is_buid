using System;
using System.Windows.Forms;

namespace BUILD.modules.Objects
{
    public partial class SearchForm : Form
    {
        public string ReturnValueSearchString { get; set; }
        public int ReturnValueSearchColumn { get; set; }

        public SearchForm(int columnCount)
        {
            InitializeComponent();
            this.numericUpDown1.Maximum = columnCount + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReturnValueSearchColumn = Convert.ToInt32(this.numericUpDown1.Value);
                this.ReturnValueSearchString = this.textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Oшибка поиска");
                this.Close();
            }
        }
    }
}
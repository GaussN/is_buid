using System.Windows.Forms;

namespace BUILD.modules
{
    public partial class ReportForm : Form
    {
        public ReportForm(string text)
        {
            InitializeComponent();
            this.richTextBox1.Text = text;
        }
    }
}
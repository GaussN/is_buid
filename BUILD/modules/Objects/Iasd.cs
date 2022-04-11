using System.Windows.Forms;

namespace BUILD.modules.Objects
{
    public interface Iasd
    {
        void Insert();
        void Change(DataGridViewRow row);
        void Delete(DataGridViewRow row);
        void Update(TableService servise, DataGridView grid);
    }
}
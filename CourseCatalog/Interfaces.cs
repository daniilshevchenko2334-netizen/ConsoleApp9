using System.Windows.Forms;

namespace CourseCatalog
{
    public interface IIdentifiable<TKey>
    {
        TKey Id { get; }
    }

    public interface IDisplayable
    {
        void Display(ListBox listBox);
    }

    public interface IExportable : IDisplayable
    {
        string GetExportData();
    }
}

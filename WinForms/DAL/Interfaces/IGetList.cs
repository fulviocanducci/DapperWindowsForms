using WinForms.Models;
namespace WinForms.DAL.Interfaces
{
    public interface IGetList<T>
    {
        IList<People> GetList();
        IList<People> GetList(string filter);
    }
}

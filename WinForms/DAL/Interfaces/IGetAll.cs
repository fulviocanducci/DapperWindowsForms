namespace WinForms.DAL.Interfaces
{
    public interface IGetAll<T>
    {
        IEnumerable<T> GetAll();
    }
}

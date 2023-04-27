namespace WinForms.DAL.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T model);
    }
}

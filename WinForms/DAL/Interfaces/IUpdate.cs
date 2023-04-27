namespace WinForms.DAL.Interfaces
{
    public interface IUpdate<T>
    {
        bool Update(T model);
    }
}

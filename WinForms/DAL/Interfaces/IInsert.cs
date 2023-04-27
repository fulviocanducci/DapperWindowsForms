namespace WinForms.DAL.Interfaces
{
    public interface IInsert<T>
    {
        long Insert(T model);
    }
}

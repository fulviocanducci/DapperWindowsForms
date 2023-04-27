namespace WinForms.DAL.Interfaces
{
    public interface IFind<T, TKey>
    {
        T? Find(TKey id);
    }
}

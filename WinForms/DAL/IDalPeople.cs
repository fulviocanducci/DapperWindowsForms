using WinForms.DAL.Interfaces;
using WinForms.Models;
namespace WinForms.DAL
{
    public interface IDalPeople :  IInsert<People>, IUpdate<People>, IGetAll<People>, IGetList<People>, IFind<People, int>, IDelete<People> 
   {
   }
}

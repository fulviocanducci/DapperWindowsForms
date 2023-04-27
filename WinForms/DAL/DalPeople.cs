using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using WinForms.Models;
namespace WinForms.DAL
{
   public class DalPeople : IDalPeople
   {
      private readonly SqlConnection _sqlConnection;

      public DalPeople(SqlConnection sqlConnection)
      {
         _sqlConnection = sqlConnection;
      }

      public IEnumerable<People> GetAll()
      {
         return _sqlConnection.GetAll<People>();
      }

      public IList<People> GetList()
      {
         return GetAll().ToList();
      }

      public IList<People> GetList(string filter)
      {
         return _sqlConnection.Query<People>("SELECT * FROM Peoples WHERE Name Like @Name ORDER BY Name ASC", new { Name = $"%{filter}%" }).ToList();
      }

      public People? Find(int id)
      {
         return _sqlConnection.Get<People>(id);
      }

      public long Insert(People model)
      {
         return _sqlConnection.Insert(model);
      }

      public bool Update(People model)
      {
         return _sqlConnection.Update(model);
      }

      public bool Delete(People model)
      {
         return _sqlConnection.Delete(model);
      }
   }
}

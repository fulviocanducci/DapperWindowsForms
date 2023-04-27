using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using WinForms.Models;
namespace WinForms.DAL
{
   public class DalPeople
   {
      private readonly SqlConnection _sqlConnection;

      public DalPeople(SqlConnection sqlConnection)
      {
         _sqlConnection = sqlConnection;
      }

      public IEnumerable<People> GetAll()
      {
         return _sqlConnection.Query<People>("SELECT * FROM Peoples ORDER BY Name ASC");
      }

      public IList<People> GetList()
      {
         return GetAll().ToList();
      }

      public IList<People> GetList(string name)
      {
         return _sqlConnection.Query<People>("SELECT * FROM Peoples WHERE Name Like @Name ORDER BY Name ASC", new {Name = $"%{name}%"}).ToList();
      }

      public People? Get(int id)
      {
         return _sqlConnection.QueryFirst<People>("SELECT * FROM Peoples WHERE Id=@Id", new { Id = id });
      }

      public long Insert(People people)
      {
         return _sqlConnection.Insert(people);
      }

      public bool Update(People people)
      {
         return _sqlConnection.Update(people);
      }
   }
}

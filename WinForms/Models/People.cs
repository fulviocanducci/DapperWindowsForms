using Dapper.Contrib.Extensions;

namespace WinForms.Models
{
   [Table("Peoples")]
   public class People
   {
      public People(int id, string name, bool active)
      {
         Id = id;
         Name = name;
         Active = active;
      }

      public People(string name, bool active)
      {
         Name = name;
         Active = active;
      }

      [Key()]
      public int Id { get; set; }

      public string Name { get; set; } = null!;

      public bool Active { get; set; }
   }
}

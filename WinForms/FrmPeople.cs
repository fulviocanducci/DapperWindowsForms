using System.Text;
using WinForms.DAL;
using WinForms.Models;
namespace WinForms
{
   public partial class FrmPeople : Form
   {
      public DalPeople DalPeople { get; }
      public int? Id { get; set; }
      public FrmPeople(DalPeople dalPeople, int? id = null)
      {
         InitializeComponent();
         DalPeople = dalPeople;
         Id = id;
      }


      private void ButEnd_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void FrmPeople_Load(object sender, EventArgs e)
      {
         if (Id == null) // new register
         {
            TxtId.Text = "000";
            TxtName.Text = "";
            ChkActive.Checked = true;
         }
         else // update register
         {
            People? people = DalPeople.Get(Id.Value);
            if (people != null)
            {
               TxtId.Text = people.Id.ToString("000");
               TxtName.Text = people.Name;
               ChkActive.Checked = people.Active;
            }
         }
      }

      private void ButSave_Click(object sender, EventArgs e)
      {
         StringBuilder strValidation = new StringBuilder();
         if (string.IsNullOrEmpty(TxtId.Text))
         {
            strValidation.Append("Id inválido");
         }
         if (string.IsNullOrEmpty(TxtName.Text))
         {
            strValidation.Append("Nome inválido");
         }

         if (strValidation.Length > 0)
         {
            MessageBox.Show(strValidation.ToString(), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            if (Id == null)
            {
               DalPeople.Insert(new People(TxtName.Text, ChkActive.Checked));
            }
            else
            {
               DalPeople.Update(new People(Id.Value, TxtName.Text, ChkActive.Checked));
            }
            Close();
         }
      }
   }
}

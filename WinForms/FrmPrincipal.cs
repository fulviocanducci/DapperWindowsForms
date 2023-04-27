using Microsoft.Data.SqlClient;
using WinForms.DAL;

namespace WinForms
{
   public partial class FrmPrincipal : Form
   {
      internal const string StringConnection = "Server=127.0.0.1;Database=EFTest;User Id=sa;Password=senha;TrustServerCertificate=True";
      protected SqlConnection SqlConnection { get; private set; }
      protected DalPeople DalPeople { get; private set; }

      public FrmPrincipal()
      {
         InitializeComponent();
         SqlConnection = new(StringConnection);
         DalPeople = new(SqlConnection);
      }

      private void LoadDataGridViewPeople(string name = "")
      {
         DataGridViewPeople.AutoGenerateColumns = false;
         DataGridViewPeople.DataSource = DalPeople.GetList(name);
         DataGridViewPeople.Refresh();
         DataGridViewPeople.Update();
      }

      private void LoadFrmPeople(int? id = null)
      {
         FrmPeople frmPeople = new(DalPeople, id);
         frmPeople.ShowDialog();
         LoadDataGridViewPeople(TxtFilter.Text);
      }

      private void FrmPrincipal_Load(object sender, EventArgs e)
      {
         LoadDataGridViewPeople(TxtFilter.Text);
      }

      private void BtuEnd_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void DataGridViewPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         object itemId = DataGridViewPeople.Rows[e.RowIndex].Cells[0].Value;
         if (int.TryParse(itemId.ToString(), out int id))
         {
            LoadFrmPeople(id);
         }
      }

      private void ButNew_Click(object sender, EventArgs e)
      {
         LoadFrmPeople(null);
      }

      private void ButEdit_Click(object sender, EventArgs e)
      {
         if (DataGridViewPeople.Rows.Count > 0 && DataGridViewPeople.CurrentRow.Index >= 0)
         {
            DataGridViewPeople_CellDoubleClick(DataGridViewPeople, new DataGridViewCellEventArgs(0, DataGridViewPeople.CurrentRow.Index));
         }
      }

      private void ButFilter_Click(object sender, EventArgs e)
      {
         LoadDataGridViewPeople(TxtFilter.Text);
      }

      private void TxtFilter_KeyUp(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            ButFilter.PerformClick();
         }
      }

      private void DataGridViewPeople_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            ButEdit.PerformClick();
         }
      }
   }
}
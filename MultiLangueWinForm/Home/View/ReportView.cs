using System.Drawing;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.IO;

namespace Home.View
{
  public partial class ReportView : UserControl
  {
    public ReportView()
    {
      InitializeComponent();

      var classeur = new ReoGridControl
      {
        Dock = DockStyle.Fill
      };


      var onglet = classeur.CurrentWorksheet;
      //onglet.Cells["A1"].Data = "Bonjour le monde";
      //onglet.Cells["A1"].Style.TextColor = Color.Red;



      onglet.Resize(14, 11);

     // classeur.Load(@"D:\Users\knsamoun\Desktop\Brouillon\ExempleC66.xlsx");



      int totalWidth = this.PnlRapport.Width;
      var totalHeigth = this.PnlRapport.Height;

      ushort rowTail = (ushort) (totalWidth/ onglet.RowCount );
      ushort colTail = (ushort) (totalHeigth/ onglet.ColumnCount);

      onglet.SetRowsHeight(0, onglet.RowCount, 47);
      onglet.SetColumnsWidth(0, onglet.ColumnCount, 123);

      //onglet["D1"] = "Counterparty Name";
      //onglet["E1"] = "LEI Code";
      //onglet["F1"] = "Counterparty Sector";
      //onglet["H1"] = " Residence of Counterparty";
      //onglet["I1"] = " Product Type";
      //onglet["G1"] = " Weighted average initial maturity (days)";

     

      classeur.AutoSize = true;
      foreach (var cell in onglet.Cells)
      {
        
        //cell.Style.Strikethrough = false;
        //cell.Style.Padding = new PaddingValue(10);
      }

      


      // var sheet = grid.CreateWorksheet("Nouvelle page");
      //grid.Worksheets.Add(sheet);
      this.PnlRapport.Controls.Add(classeur);

      classeur.Save(@"D: \Users\knsamoun\Desktop\Brouillon\fichier2.xlsx", FileFormat.Excel2007);

      /*
       * var worksheet = reoGridControl1.CurrentWorksheet;
        worksheet.Cells["A1"].Data = "Hello World!";
        worksheet.Cells["A1"].Style.TextColor = Color.Red;
       */
    }

    private void BtnHide_Click(object sender, System.EventArgs e)
    {
      this.PnlMenuRapport.Visible = false;
    }
  }
}
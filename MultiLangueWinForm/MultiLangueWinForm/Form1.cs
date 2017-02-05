namespace MultiLangMain
{
  using System.Collections.Generic;
  using System.Linq;
  using System.Windows.Forms;

  using Commun;

  using Home;

  using Parameter;

  /// <summary>
  /// Application's général view
  /// </summary>
  /// <seealso cref="System.Windows.Forms.Form" />
  public partial class AppName : Form
  {
    #region Fields

    /// <summary>
    /// User controls's Collection
    /// </summary>
    private readonly List<UserControl> userControls;

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="AppName"/> class.
    /// </summary>
    public AppName()
    {
      this.InitializeComponent();

      var parameter = new ParameterManager();
      var home = new HomeManager();

      parameter.View.Dock = DockStyle.Fill;
      home.View.Dock = DockStyle.Fill;
      this.userControls = new List<UserControl> { parameter.View, home.View };

      // Charge la vue par defaut => home
      this.PnlModule.Controls.Add(home.View);

      this.InitLabel(null);

      ParameterManager.OnChangeLang += (s, lang) => { this.InitLabel(lang); };
    }

    #endregion

    #region Privates methods

    /// <summary>
    /// Labels initialization.
    /// </summary>
    private void InitLabel(string lang)
    {
      this.BtnHome.Text = ParameterManager.GetLanguage(AllBtn.GetBtnName(BntName.BtnHome), lang);
      this.BtnParameter.Text = ParameterManager.GetLanguage(AllBtn.GetBtnName(BntName.BtnParameter), lang);
    }

    /// <summary>
    /// Shows the view.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void ShowView(object sender, System.EventArgs e)
    {
      this.userControls.ForEach(u => this.PnlModule.Controls.Remove(u));

      var view = this.userControls.First(u => u.Name.Contains(((Button)sender).Name.Replace("Btn", string.Empty)));

      this.PnlModule.Controls.Add(view);
    }

    #endregion
  }
}
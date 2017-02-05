namespace Home.View
{
  using System.Windows.Forms;
  using Commun;
  using Parameter;

  /// <summary>
  /// Home view model
  /// </summary>
  /// <seealso cref="UserControl" />
  public partial class HomeView : UserControl
  {
    #region Constructore

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeView"/> class.
    /// </summary>
    public HomeView()
    {
      InitializeComponent();

      this.InitBtn(null);

      ParameterManager.OnChangeLang += (s, e) => { this.InitBtn(e); };
    }

    #endregion

    #region Privates methods

    /// <summary>
    /// Initializes all Btn of this view.
    /// </summary>
    /// <param name="lang">The language.</param>
    private void InitBtn(string lang)
    {
      this.LblFemme.Text = ParameterManager.GetLanguage(AllLabels.GetLabelNane(LabelName.LblFemme), lang);
      this.BtnAnnuler.Text = ParameterManager.GetLanguage(AllBtn.GetBtnName(BntName.BtnAnnuler), lang);
    }

    #endregion
  }
}

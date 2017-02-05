namespace Parameter.View
{
  using System.Windows.Forms;

  /// <summary>
  /// Parameter view
  /// </summary>
  /// <seealso cref="UserControl" />
  public partial class ParameterView : UserControl
  {
    #region delegate and Event

    /// <summary>
    /// Chanche language delegate
    /// </summary>
    internal delegate void ChangeLang();

    /// <summary>
    /// Occurs when [on change language].
    /// </summary>
    internal event ChangeLang OnChangeLang;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the sending language.
    /// </summary>
    internal string SendingLang { get; set; }

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ParameterView"/> class.
    /// </summary>
    public ParameterView()
    {
      InitializeComponent();
      this.Init();
    }

    #endregion

    #region Privates methods

    /// <summary>
    /// Change the application language on click.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void BtnChangeLangClick(object sender, System.EventArgs e)
    {
      ((Button) sender).Text = ((Button)sender).Text == "Français" ? "Anglais" : "Français";

      this.SendingLang = ((Button) sender).Text;
      OnChangeLang?.Invoke();
    }

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    private void Init()
      => this.BtnChangeLang.Text = "Français";

    #endregion
  }
}

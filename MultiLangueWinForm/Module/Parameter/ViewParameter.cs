namespace Module.Parameter
{
  using Commun;
  using System;  
  using System.Windows.Forms;

  /// <summary>
  /// Parameter view
  /// </summary>
  /// <seealso cref="UserControl" />
  public partial class ViewParameter : UserControl
  {
    #region Fields
    
    /// <summary>
    /// Gets or sets the parameter.
    /// </summary>
    public static ParameterManager Parameter { get; set; }

    private string _fr = "Français";
    private string _ang = "Anglais";

    #endregion

    #region delegate and Event

    /// <summary>
    /// Chanche language delegate
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    public delegate void ChangeLang(object sender, EventArgs e);

    /// <summary>
    /// Occurs when [on change language].
    /// </summary>
    public static event ChangeLang OnChangeLang;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="ViewParameter"/> class.
    /// </summary>
    public ViewParameter()
    {
      InitializeComponent();

      Parameter = new ParameterManager();
      this.BtnChangeLang.Text = _fr;

      this.LblChangLang.Text = Parameter.GetLanguage(AllLabels.GetLabelNane(LabelName.LblChangeLang));
    }

    public string SelectedLang { get; set; } 

    private void BtnChangeLangClick(object sender, EventArgs e)
    {
      var s = (Button) sender;
      s.Text = this.BtnChangeLang.Text == _ang ? _fr : _ang;
      SelectedLang = s.Text;

      ViewParameter.OnChangeLang?.Invoke(s, e);
      this.LblChangLang.Text = Parameter.GetLanguage(AllLabels.GetLabelNane(LabelName.LblChangeLang));
    }
  }
}

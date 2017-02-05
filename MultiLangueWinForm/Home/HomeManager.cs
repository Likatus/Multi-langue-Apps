namespace Home
{
  using View;

  /// <summary>
  /// Home manager
  /// </summary>
  public class HomeManager
  {
    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="HomeManager"/> class.
    /// </summary>
    public HomeManager()
    {
      this.View = new HomeView();
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the view.
    /// </summary>
    /// <value>
    /// The view.
    /// </value>
    public HomeView View { get; set; }

    #endregion
  }
}
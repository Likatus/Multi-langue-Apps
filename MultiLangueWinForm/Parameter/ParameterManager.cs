namespace Parameter
{
  using View;
  using System;
  using Commun;
  using System.Collections.Generic;
  using System.Linq;
  using System.Xml.Linq;

  /// <summary>
  /// Parameter manager
  /// </summary>
  public class ParameterManager
  {
    #region Properties

    /// <summary>
    /// Language's collection 
    /// </summary>
    private static List<XElement> langues;

    /// <summary>
    /// Default language
    /// </summary>
    private static string lang;

    #endregion

    #region delegate and Event

    /// <summary>
    /// Chanche language delegate
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    public delegate void ChangeLang(object sender, string e);

    /// <summary>
    /// Occurs when [on change language].
    /// </summary>
    public static event ChangeLang OnChangeLang;

    #endregion

    #region Constructor

    /// <summary>
    /// Initializes a new instance of the <see cref="ParameterManager"/> class.
    /// </summary>
    public ParameterManager()
    {
      var xDoc = XDocument.Load("Data\\Lang.xml");
      langues = xDoc.Document?.Root?.Elements().ToList();
      lang = Constante.Ang;

      this.View = new ParameterView();

      View.OnChangeLang += () =>
      {
        OnChangeLang?.Invoke(this, this.View.SendingLang);
      };
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the view.
    /// </summary>
    public ParameterView View { get; set; }

    #endregion

    #region Publics methods

    /// <summary>
    /// Gets the language.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="language">Langue</param>
    public static string GetLanguage(string key, string language)
    {
      if (language == null)
        ParameterManager.lang = Constante.Fr;
      else
        ParameterManager.lang = language.Contains(Constante.Fr) ? Constante.Fr : Constante.Ang;

      try
      {
        return langues?.Where(l => l.Attribute(Constante.Key)?.Value == key)
          .Select(l => l.Attribute(ParameterManager.lang)?.Value).First();
      }
      catch (Exception e)
      {
        // TODO : Keita - Mieux gérér l'exception
        throw new Exception(e.Message);
      }
    }

    #endregion
  }
}
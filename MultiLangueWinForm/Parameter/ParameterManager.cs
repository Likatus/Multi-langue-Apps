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
        /// Change language delegate
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public delegate void ChangeLang(object sender, string e);

        /// <summary>
        /// Occurs when the language change.
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
            langues = xDoc.Document != null
                ? (xDoc.Document.Root != null
                    ? xDoc.Document.Root.Elements().ToList()
                    : null)
                : null;

            lang = Constante.Ang;

            this.View = new ParameterView();

            View.OnChangeLang += () =>
            {
                if (OnChangeLang != null)
                    OnChangeLang(this, this.View.SendingLang);
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
                lang = Constante.Fr;
            else
                lang = language.Contains(Constante.Fr) ? Constante.Fr : Constante.Ang;

            try
            {
                return langues != null
                    ? langues.Where(l =>
                        {
                            var xAttribute = l.Attribute(Constante.Key);
                            return xAttribute != null && (xAttribute.Value) == key;
                        })
                        .Select(l =>
                        {
                            var xAttribute = l.Attribute(lang);
                            if (xAttribute != null)
                                return l.Attribute(lang) != null ? xAttribute.Value : null;
                            return null;
                        }).First()
                    : null;
            }
            catch (Exception e)
            {
                // TODO : Likatus - Mieux gérér l'exception
                throw new Exception(e.Message);
            }
        }

        #endregion
    }
}
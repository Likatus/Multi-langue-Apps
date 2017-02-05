using Commun;

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

            this.CbLang.SelectedIndex = 0;

           // ParameterManager.OnChangeLang += (s, e) => { this.ChangeLangage(e); };
        }

        #endregion

        #region Privates methods

        /// <summary>
        /// Occurs when the selected index changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CbLang_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.SendingLang = ((ComboBox)sender).Text;

            if (OnChangeLang != null)
                this.OnChangeLang();
        }

        #endregion
    }
}

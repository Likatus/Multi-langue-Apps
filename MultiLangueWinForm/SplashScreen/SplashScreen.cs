using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
  public partial class SplashScreen : Form
  {
    #region Fields

    // Threading
    private static SplashScreen _frmSplash;

    // Fade in and out.
    private double _dblOpacityIncrement = .05;
    private double _dblOpacityDecrement = .08;
    private const int TIMER_INTERVAL = 50;
    private string _status;

    #endregion Member Variables

    public SplashScreen()
    {
      InitializeComponent();

      UpdateTimer.Interval = TIMER_INTERVAL;
      UpdateTimer.Start();
    }

    public void ShowSplashScreen()
    {
      // Make sure it's only launched once.
      if (_frmSplash != null) return;

      Task.Run(() =>
      {
        this.ShowForm();
      });
    }

    private void ShowForm()
    {
      _frmSplash = new SplashScreen();
      Application.Run(_frmSplash);
    }

    public void CloseForm()
    {
      if (_frmSplash != null && _frmSplash.IsDisposed == false)
      {
        // Make it start going away.
        _frmSplash._dblOpacityIncrement = -_frmSplash._dblOpacityDecrement;
      }

      _frmSplash = null;
    }

    public void SetStatus(string newStatus)
    {
      var msg = $"Loading of module {newStatus} ...";
      SetStatus(msg, true);
    }

    public void SetStatus(string newStatus, bool setReference)
    {
      if (_frmSplash == null)
        return;

      _frmSplash._status = newStatus;
    }

    private void UpdateTimer_Tick(object sender, System.EventArgs e)
    {
      lblChargement.Text = _status;

      // Calculate opacity
      if (this.Opacity < 1)
        this.Opacity += _dblOpacityIncrement;

      // Closing down splash screen
      if (this.Opacity > 0)
        this.Opacity += _dblOpacityIncrement;
      else
      {
        UpdateTimer.Stop();
        this.Close();
      }
    }
  }
}


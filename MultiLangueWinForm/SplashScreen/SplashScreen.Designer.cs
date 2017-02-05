namespace SplashScreen
{
  partial class SplashScreen
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
      this.lblChargement = new System.Windows.Forms.Label();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // UpdateTimer
      // 
      this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
      // 
      // lblChargement
      // 
      this.lblChargement.AutoSize = true;
      this.lblChargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblChargement.Location = new System.Drawing.Point(117, 182);
      this.lblChargement.Name = "lblChargement";
      this.lblChargement.Size = new System.Drawing.Size(51, 20);
      this.lblChargement.TabIndex = 2;
      this.lblChargement.Text = "label1";
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = global::SplashScreen.Properties.Resources.LogoBarclays2;
      this.pictureBox2.Location = new System.Drawing.Point(12, 12);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(455, 84);
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::SplashScreen.Properties.Resources.ajax_loader;
      this.pictureBox1.Location = new System.Drawing.Point(12, 100);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(291, 183);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // SplashScreen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(479, 290);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.lblChargement);
      this.Controls.Add(this.pictureBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SplashScreen";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Chargement";
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer UpdateTimer;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblChargement;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}
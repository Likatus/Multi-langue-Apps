namespace MultiLangMain
{
  partial class AppName
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.panel1 = new System.Windows.Forms.Panel();
      this.BtnParameter = new System.Windows.Forms.Button();
      this.BtnHome = new System.Windows.Forms.Button();
      this.PnlModule = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.BtnParameter);
      this.panel1.Controls.Add(this.BtnHome);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(606, 57);
      this.panel1.TabIndex = 4;
      // 
      // BtnParameter
      // 
      this.BtnParameter.Location = new System.Drawing.Point(94, 11);
      this.BtnParameter.Name = "BtnParameter";
      this.BtnParameter.Size = new System.Drawing.Size(75, 38);
      this.BtnParameter.TabIndex = 5;
      this.BtnParameter.Text = "Parameter";
      this.BtnParameter.UseVisualStyleBackColor = true;
      this.BtnParameter.Click += new System.EventHandler(this.ShowView);
      // 
      // BtnHome
      // 
      this.BtnHome.Location = new System.Drawing.Point(13, 11);
      this.BtnHome.Name = "BtnHome";
      this.BtnHome.Size = new System.Drawing.Size(75, 40);
      this.BtnHome.TabIndex = 4;
      this.BtnHome.Text = "Home";
      this.BtnHome.UseVisualStyleBackColor = true;
      this.BtnHome.Click += new System.EventHandler(this.ShowView);
      // 
      // PnlModule
      // 
      this.PnlModule.BackColor = System.Drawing.SystemColors.Control;
      this.PnlModule.Dock = System.Windows.Forms.DockStyle.Fill;
      this.PnlModule.Location = new System.Drawing.Point(0, 57);
      this.PnlModule.Name = "PnlModule";
      this.PnlModule.Size = new System.Drawing.Size(606, 360);
      this.PnlModule.TabIndex = 5;
      // 
      // AppName
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(606, 417);
      this.Controls.Add(this.PnlModule);
      this.Controls.Add(this.panel1);
      this.Name = "AppName";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button BtnParameter;
    private System.Windows.Forms.Button BtnHome;
    private System.Windows.Forms.Panel PnlModule;
  }
}


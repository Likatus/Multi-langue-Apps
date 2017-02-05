namespace Parameter.View
{
  partial class ParameterView
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
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur de composants

    /// <summary> 
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.BtnChangeLang = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnChangeLang
      // 
      this.BtnChangeLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnChangeLang.Location = new System.Drawing.Point(114, 120);
      this.BtnChangeLang.Name = "BtnChangeLang";
      this.BtnChangeLang.Size = new System.Drawing.Size(213, 93);
      this.BtnChangeLang.TabIndex = 0;
      this.BtnChangeLang.Text = "Langue";
      this.BtnChangeLang.UseVisualStyleBackColor = true;
      this.BtnChangeLang.Click += new System.EventHandler(this.BtnChangeLangClick);
      // 
      // ParameterView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Highlight;
      this.Controls.Add(this.BtnChangeLang);
      this.Name = "ParameterView";
      this.Size = new System.Drawing.Size(426, 351);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button BtnChangeLang;
  }
}

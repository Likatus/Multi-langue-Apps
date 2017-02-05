namespace Module.Parameter
{
  partial class ViewParameter
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
      this.LblChangLang = new System.Windows.Forms.Label();
      this.BtnChangeLang = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // LblChangLang
      // 
      this.LblChangLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.LblChangLang.AutoSize = true;
      this.LblChangLang.Location = new System.Drawing.Point(175, 107);
      this.LblChangLang.Name = "LblChangLang";
      this.LblChangLang.Size = new System.Drawing.Size(102, 13);
      this.LblChangLang.TabIndex = 3;
      this.LblChangLang.Text = "Changer la langue : ";
      // 
      // BtnChangeLang
      // 
      this.BtnChangeLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.BtnChangeLang.Location = new System.Drawing.Point(164, 136);
      this.BtnChangeLang.Name = "BtnChangeLang";
      this.BtnChangeLang.Size = new System.Drawing.Size(122, 31);
      this.BtnChangeLang.TabIndex = 2;
      this.BtnChangeLang.Text = "button1";
      this.BtnChangeLang.UseVisualStyleBackColor = true;
      this.BtnChangeLang.Click += new System.EventHandler(this.BtnChangeLangClick);
      // 
      // ViewParameter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Controls.Add(this.LblChangLang);
      this.Controls.Add(this.BtnChangeLang);
      this.Name = "ViewParameter";
      this.Size = new System.Drawing.Size(471, 311);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LblChangLang;
    private System.Windows.Forms.Button BtnChangeLang;
  }
}

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
            this.CbLang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CbLang
            // 
            this.CbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLang.FormattingEnabled = true;
            this.CbLang.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.CbLang.Location = new System.Drawing.Point(17, 14);
            this.CbLang.Name = "CbLang";
            this.CbLang.Size = new System.Drawing.Size(109, 21);
            this.CbLang.TabIndex = 1;
            this.CbLang.SelectedIndexChanged += new System.EventHandler(this.CbLang_SelectedIndexChanged);
            // 
            // ParameterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.CbLang);
            this.Name = "ParameterView";
            this.Size = new System.Drawing.Size(426, 351);
            this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.ComboBox CbLang;
    }
}

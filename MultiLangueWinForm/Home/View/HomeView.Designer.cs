﻿namespace Home.View
{
  partial class HomeView
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
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.LblFemme = new System.Windows.Forms.Label();
            this.LblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAnnuler.Location = new System.Drawing.Point(14, 271);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(192, 92);
            this.BtnAnnuler.TabIndex = 0;
            this.BtnAnnuler.Text = "Home";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // LblFemme
            // 
            this.LblFemme.AutoSize = true;
            this.LblFemme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFemme.Location = new System.Drawing.Point(26, 93);
            this.LblFemme.Name = "LblFemme";
            this.LblFemme.Size = new System.Drawing.Size(60, 24);
            this.LblFemme.TabIndex = 1;
            this.LblFemme.Text = "label1";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LblMessage.Location = new System.Drawing.Point(27, 34);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(52, 18);
            this.LblMessage.TabIndex = 2;
            this.LblMessage.Text = "label1";
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.LblFemme);
            this.Controls.Add(this.BtnAnnuler);
            this.Name = "HomeView";
            this.Size = new System.Drawing.Size(531, 377);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button BtnAnnuler;
    private System.Windows.Forms.Label LblFemme;
    private System.Windows.Forms.Label LblMessage;
  }
}

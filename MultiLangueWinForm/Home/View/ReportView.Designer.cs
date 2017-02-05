namespace Home.View
{
  partial class ReportView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportView));
      this.PnlMenuRapport = new System.Windows.Forms.Panel();
      this.PnlRapport = new System.Windows.Forms.Panel();
      this.BtnHide = new System.Windows.Forms.Button();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.PnlMenuRapport.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // PnlMenuRapport
      // 
      this.PnlMenuRapport.BackColor = System.Drawing.SystemColors.ControlDark;
      this.PnlMenuRapport.Controls.Add(this.BtnHide);
      this.PnlMenuRapport.Location = new System.Drawing.Point(611, 98);
      this.PnlMenuRapport.Name = "PnlMenuRapport";
      this.PnlMenuRapport.Size = new System.Drawing.Size(182, 477);
      this.PnlMenuRapport.TabIndex = 0;
      // 
      // PnlRapport
      // 
      this.PnlRapport.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.PnlRapport.Location = new System.Drawing.Point(0, 198);
      this.PnlRapport.Name = "PnlRapport";
      this.PnlRapport.Size = new System.Drawing.Size(491, 377);
      this.PnlRapport.TabIndex = 1;
      // 
      // BtnHide
      // 
      this.BtnHide.Location = new System.Drawing.Point(104, 3);
      this.BtnHide.Name = "BtnHide";
      this.BtnHide.Size = new System.Drawing.Size(75, 31);
      this.BtnHide.TabIndex = 0;
      this.BtnHide.Text = "Hide";
      this.BtnHide.UseVisualStyleBackColor = true;
      this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.AutoSize = false;
      this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
      this.toolStrip1.Location = new System.Drawing.Point(308, 25);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(111, 53);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 50);
      this.toolStripButton1.Text = "Hide menu";
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(23, 50);
      this.toolStripButton2.Text = "toolStripButton2";
      // 
      // ReportView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.PnlRapport);
      this.Controls.Add(this.PnlMenuRapport);
      this.Name = "ReportView";
      this.Size = new System.Drawing.Size(793, 575);
      this.PnlMenuRapport.ResumeLayout(false);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel PnlMenuRapport;
    private System.Windows.Forms.Panel PnlRapport;
    private System.Windows.Forms.Button BtnHide;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
  }
}

namespace BlacksmithManager.Reportes
{
    partial class UsuariosReportViewer
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
            this.MyCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListadoUsuarios = new BlacksmithManager.Reportes.ListadoUsuarios();
            this.SuspendLayout();
            // 
            // MyCrystalReportViewer
            // 
            this.MyCrystalReportViewer.ActiveViewIndex = 0;
            this.MyCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MyCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MyCrystalReportViewer.Name = "MyCrystalReportViewer";
            this.MyCrystalReportViewer.ReportSource = this.ListadoUsuarios;
            this.MyCrystalReportViewer.Size = new System.Drawing.Size(1077, 450);
            this.MyCrystalReportViewer.TabIndex = 0;
            this.MyCrystalReportViewer.Load += new System.EventHandler(this.MyCrystalReportViewer_Load);
            // 
            // UsuariosReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.MyCrystalReportViewer);
            this.Name = "UsuariosReportViewer";
            this.Text = "UsuariosReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MyCrystalReportViewer;
        private ListadoUsuarios ListadoUsuarios;
    }
}
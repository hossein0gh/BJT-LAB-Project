namespace BJT_LAb_Project
{
    partial class FormPlot
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
            this.plot = new ScottPlot.WinForms.FormsPlot();
            this.SuspendLayout();
            // 
            // plot
            // 
            this.plot.DisplayScale = 0F;
            this.plot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot.Location = new System.Drawing.Point(0, 0);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(782, 553);
            this.plot.TabIndex = 25;
            // 
            // FormPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.plot);
            this.Name = "FormPlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlot";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plot;
    }
}
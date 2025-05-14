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
            this.plotForm = new ScottPlot.WinForms.FormsPlot();
            this.SuspendLayout();
            // 
            // plotForm
            // 
            this.plotForm.DisplayScale = 0F;
            this.plotForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotForm.Location = new System.Drawing.Point(0, 0);
            this.plotForm.Name = "plotForm";
            this.plotForm.Size = new System.Drawing.Size(782, 553);
            this.plotForm.TabIndex = 25;
            // 
            // FormPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.plotForm);
            this.Name = "FormPlot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlot";
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot plotForm;
    }
}
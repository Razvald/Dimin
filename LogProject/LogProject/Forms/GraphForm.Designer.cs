namespace LogProject.Forms
{
    partial class GraphForm
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            cmb = new ComboBox();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Bottom;
            formsPlot1.Location = new Point(0, 41);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(800, 409);
            formsPlot1.TabIndex = 0;
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(12, 12);
            cmb.Name = "cmb";
            cmb.Size = new Size(121, 23);
            cmb.TabIndex = 1;
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmb);
            Controls.Add(formsPlot1);
            Name = "GraphForm";
            Text = "Graph";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ComboBox cmb;
    }
}
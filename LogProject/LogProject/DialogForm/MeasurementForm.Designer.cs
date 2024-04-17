namespace LogProject.DialogForm
{
    partial class MeasurementForm
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
            label1 = new Label();
            cmbMeasurementProtocol = new ComboBox();
            cmbGeologicalObject = new ComboBox();
            label2 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 0;
            label1.Text = "Measurement Protocol";
            // 
            // cmbMeasurementProtocol
            // 
            cmbMeasurementProtocol.FormattingEnabled = true;
            cmbMeasurementProtocol.Location = new Point(12, 33);
            cmbMeasurementProtocol.Name = "cmbMeasurementProtocol";
            cmbMeasurementProtocol.Size = new Size(226, 29);
            cmbMeasurementProtocol.TabIndex = 1;
            // 
            // cmbGeologicalObject
            // 
            cmbGeologicalObject.FormattingEnabled = true;
            cmbGeologicalObject.Location = new Point(12, 89);
            cmbGeologicalObject.Name = "cmbGeologicalObject";
            cmbGeologicalObject.Size = new Size(226, 29);
            cmbGeologicalObject.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 2;
            label2.Text = "Geological Object";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 193);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 51);
            btnSave.TabIndex = 4;
            btnSave.Text = "Создать/Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MeasurementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 244);
            Controls.Add(btnSave);
            Controls.Add(cmbGeologicalObject);
            Controls.Add(label2);
            Controls.Add(cmbMeasurementProtocol);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MeasurementForm";
            Text = "AddMeasurement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMeasurementProtocol;
        private ComboBox cmbGeologicalObject;
        private Label label2;
        private Button btnSave;
    }
}
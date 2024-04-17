namespace LogProject.DialogForm
{
    partial class GeologicalObjectsForm
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
            cmbType = new ComboBox();
            txbName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbDepth = new TextBox();
            label4 = new Label();
            txbXCoordinates = new TextBox();
            label5 = new Label();
            txbYCoordinates = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(12, 92);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(226, 29);
            cmbType.TabIndex = 1;
            // 
            // txbName
            // 
            txbName.Location = new Point(12, 33);
            txbName.Name = "txbName";
            txbName.Size = new Size(226, 29);
            txbName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 3;
            label2.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 5;
            label3.Text = "Глубина";
            // 
            // txbDepth
            // 
            txbDepth.Location = new Point(12, 148);
            txbDepth.Name = "txbDepth";
            txbDepth.Size = new Size(226, 29);
            txbDepth.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 6;
            label4.Text = "Координата X";
            // 
            // txbXCoordinates
            // 
            txbXCoordinates.Location = new Point(12, 204);
            txbXCoordinates.Name = "txbXCoordinates";
            txbXCoordinates.Size = new Size(226, 29);
            txbXCoordinates.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 8;
            label5.Text = "Координата Y";
            // 
            // txbYCoordinates
            // 
            txbYCoordinates.Location = new Point(12, 260);
            txbYCoordinates.Name = "txbYCoordinates";
            txbYCoordinates.Size = new Size(226, 29);
            txbYCoordinates.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 46);
            btnSave.TabIndex = 11;
            btnSave.Text = "Создать/Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GeologicalObjectsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 350);
            Controls.Add(btnSave);
            Controls.Add(txbYCoordinates);
            Controls.Add(txbXCoordinates);
            Controls.Add(label5);
            Controls.Add(txbDepth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txbName);
            Controls.Add(cmbType);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "GeologicalObjectsForm";
            Text = "GeologicalObjects";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbType;
        private TextBox txbName;
        private Label label2;
        private Label label3;
        private TextBox txbDepth;
        private Label label4;
        private TextBox txbXCoordinates;
        private Label label5;
        private TextBox txbYCoordinates;
        private Button btnSave;
    }
}
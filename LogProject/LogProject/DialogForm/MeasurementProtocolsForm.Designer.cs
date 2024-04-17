namespace LogProject.DialogForm
{
    partial class MeasurementProtocolsForm
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
            btnSave = new Button();
            txbParameter = new TextBox();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cmbEquipment = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Дата измерения";
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 196);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "Создать/Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txbParameter
            // 
            txbParameter.Location = new Point(12, 89);
            txbParameter.Name = "txbParameter";
            txbParameter.Size = new Size(226, 29);
            txbParameter.TabIndex = 2;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(12, 33);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(226, 29);
            dtpDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(173, 21);
            label2.TabIndex = 4;
            label2.Text = "Значение измерения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 6;
            label3.Text = "Инструмент";
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(12, 145);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(226, 29);
            cmbEquipment.TabIndex = 7;
            // 
            // MeasurementProtocolsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 244);
            Controls.Add(cmbEquipment);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpDate);
            Controls.Add(txbParameter);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MeasurementProtocolsForm";
            Text = "MeasurementProtocols";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSave;
        private TextBox txbParameter;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private ComboBox cmbEquipment;
    }
}
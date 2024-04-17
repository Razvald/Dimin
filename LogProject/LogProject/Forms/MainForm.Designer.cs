namespace LogProject.Forms
{
    partial class MainForm
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
            btnAddMeasurement = new Button();
            dgvMeasurement = new DataGridView();
            dgvGeologicalObjects = new DataGridView();
            dgvMeasurementProtocols = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEditMeasurement = new Button();
            btnEditGeologicalObjects = new Button();
            label6 = new Label();
            label7 = new Label();
            btnAddGeologicalObjects = new Button();
            btnEditMeasurementProtocols = new Button();
            label8 = new Label();
            label9 = new Label();
            btnAddMeasurementProtocols = new Button();
            btnGraph = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGeologicalObjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurementProtocols).BeginInit();
            SuspendLayout();
            // 
            // btnAddMeasurement
            // 
            btnAddMeasurement.Location = new Point(12, 57);
            btnAddMeasurement.Name = "btnAddMeasurement";
            btnAddMeasurement.Size = new Size(100, 29);
            btnAddMeasurement.TabIndex = 0;
            btnAddMeasurement.Text = "Добавить";
            btnAddMeasurement.UseVisualStyleBackColor = true;
            btnAddMeasurement.Click += btnAddMeasurement_Click;
            // 
            // dgvMeasurement
            // 
            dgvMeasurement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeasurement.Location = new Point(258, 33);
            dgvMeasurement.Name = "dgvMeasurement";
            dgvMeasurement.ReadOnly = true;
            dgvMeasurement.RowTemplate.Height = 25;
            dgvMeasurement.Size = new Size(462, 144);
            dgvMeasurement.TabIndex = 1;
            dgvMeasurement.CellClick += dgvMeasurement_CellClick;
            // 
            // dgvGeologicalObjects
            // 
            dgvGeologicalObjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGeologicalObjects.Location = new Point(258, 204);
            dgvGeologicalObjects.Name = "dgvGeologicalObjects";
            dgvGeologicalObjects.ReadOnly = true;
            dgvGeologicalObjects.RowTemplate.Height = 25;
            dgvGeologicalObjects.Size = new Size(462, 125);
            dgvGeologicalObjects.TabIndex = 2;
            dgvGeologicalObjects.CellClick += dgvGeologicalObjects_CellClick;
            // 
            // dgvMeasurementProtocols
            // 
            dgvMeasurementProtocols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeasurementProtocols.Location = new Point(258, 356);
            dgvMeasurementProtocols.Name = "dgvMeasurementProtocols";
            dgvMeasurementProtocols.ReadOnly = true;
            dgvMeasurementProtocols.RowTemplate.Height = 25;
            dgvMeasurementProtocols.Size = new Size(462, 125);
            dgvMeasurementProtocols.TabIndex = 3;
            dgvMeasurementProtocols.CellClick += dgvMeasurementProtocols_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(226, 21);
            label1.TabIndex = 4;
            label1.Text = "Создать запись измерений";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 5;
            label2.Text = "Измерения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 332);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 6;
            label3.Text = "Протокол измерения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 180);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 7;
            label4.Text = "Объекты";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 89);
            label5.Name = "label5";
            label5.Size = new Size(238, 21);
            label5.TabIndex = 8;
            label5.Text = "Изменить запись измерений";
            // 
            // btnEditMeasurement
            // 
            btnEditMeasurement.Location = new Point(12, 113);
            btnEditMeasurement.Name = "btnEditMeasurement";
            btnEditMeasurement.Size = new Size(100, 29);
            btnEditMeasurement.TabIndex = 9;
            btnEditMeasurement.Text = "Изменить";
            btnEditMeasurement.UseVisualStyleBackColor = true;
            btnEditMeasurement.Click += btnEditMeasurement_Click;
            // 
            // btnEditGeologicalObjects
            // 
            btnEditGeologicalObjects.Location = new Point(12, 284);
            btnEditGeologicalObjects.Name = "btnEditGeologicalObjects";
            btnEditGeologicalObjects.Size = new Size(100, 29);
            btnEditGeologicalObjects.TabIndex = 13;
            btnEditGeologicalObjects.Text = "Изменить";
            btnEditGeologicalObjects.UseVisualStyleBackColor = true;
            btnEditGeologicalObjects.Click += btnEditGeologicalObjects_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(226, 21);
            label6.TabIndex = 12;
            label6.Text = "Изменить запись объектов";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 204);
            label7.Name = "label7";
            label7.Size = new Size(214, 21);
            label7.TabIndex = 11;
            label7.Text = "Создать запись объектов";
            // 
            // btnAddGeologicalObjects
            // 
            btnAddGeologicalObjects.Location = new Point(12, 228);
            btnAddGeologicalObjects.Name = "btnAddGeologicalObjects";
            btnAddGeologicalObjects.Size = new Size(100, 29);
            btnAddGeologicalObjects.TabIndex = 10;
            btnAddGeologicalObjects.Text = "Добавить";
            btnAddGeologicalObjects.UseVisualStyleBackColor = true;
            btnAddGeologicalObjects.Click += btnAddGeologicalObjects_Click;
            // 
            // btnEditMeasurementProtocols
            // 
            btnEditMeasurementProtocols.Location = new Point(12, 436);
            btnEditMeasurementProtocols.Name = "btnEditMeasurementProtocols";
            btnEditMeasurementProtocols.Size = new Size(100, 29);
            btnEditMeasurementProtocols.TabIndex = 17;
            btnEditMeasurementProtocols.Text = "Изменить";
            btnEditMeasurementProtocols.UseVisualStyleBackColor = true;
            btnEditMeasurementProtocols.Click += btnEditMeasurementProtocols_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 412);
            label8.Name = "label8";
            label8.Size = new Size(235, 21);
            label8.TabIndex = 16;
            label8.Text = "Изменить запись протокола";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 356);
            label9.Name = "label9";
            label9.Size = new Size(223, 21);
            label9.TabIndex = 15;
            label9.Text = "Создать запись протокола";
            // 
            // btnAddMeasurementProtocols
            // 
            btnAddMeasurementProtocols.Location = new Point(12, 380);
            btnAddMeasurementProtocols.Name = "btnAddMeasurementProtocols";
            btnAddMeasurementProtocols.Size = new Size(100, 29);
            btnAddMeasurementProtocols.TabIndex = 14;
            btnAddMeasurementProtocols.Text = "Добавить";
            btnAddMeasurementProtocols.UseVisualStyleBackColor = true;
            btnAddMeasurementProtocols.Click += btnAddMeasurementProtocols_Click;
            // 
            // btnGraph
            // 
            btnGraph.Location = new Point(570, 487);
            btnGraph.Name = "btnGraph";
            btnGraph.Size = new Size(150, 35);
            btnGraph.TabIndex = 18;
            btnGraph.Text = "Открыть граф";
            btnGraph.UseVisualStyleBackColor = true;
            btnGraph.Click += btnGraph_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 534);
            Controls.Add(btnGraph);
            Controls.Add(btnEditMeasurementProtocols);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(btnAddMeasurementProtocols);
            Controls.Add(btnEditGeologicalObjects);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btnAddGeologicalObjects);
            Controls.Add(btnEditMeasurement);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMeasurementProtocols);
            Controls.Add(dgvGeologicalObjects);
            Controls.Add(dgvMeasurement);
            Controls.Add(btnAddMeasurement);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvMeasurement).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGeologicalObjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMeasurementProtocols).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddMeasurement;
        private DataGridView dgvMeasurement;
        private DataGridView dgvGeologicalObjects;
        private DataGridView dgvMeasurementProtocols;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEditMeasurement;
        private Button btnEditGeologicalObjects;
        private Label label6;
        private Label label7;
        private Button btnAddGeologicalObjects;
        private Button btnEditMeasurementProtocols;
        private Label label8;
        private Label label9;
        private Button btnAddMeasurementProtocols;
        private Button btnGraph;
    }
}
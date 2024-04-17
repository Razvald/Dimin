using LogProject.Database;
using LogProject.DialogForm;

namespace LogProject.Forms
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly LoginForm _loginForm;
        private readonly User _user;

        public MainForm(AppDbContext context, User user, LoginForm loginForm)
        {
            InitializeComponent();
            _context = context;
            _loginForm = loginForm;
            _user = user;

            // Настройка колонок гридов
            ConfigureGridColumns();

            // Инициализация данных в гридах
            LoadMeasurementData();

            if (_user.Role != Role.Admin)
                NotAdmin();
        }

        private void NotAdmin()
        {
            btnAddGeologicalObjects.Enabled = false;
            btnAddMeasurement.Enabled = false;
            btnAddMeasurementProtocols.Enabled = false;
        }

        private void LoadMeasurementData()
        {
            // Загрузка данных из базы данных
            var measurements = _context.Measurements.ToList();

            // Отображение данных в гриде
            dgvMeasurement.DataSource = measurements;
        }

        int measurementId = -1;
        private void dgvMeasurement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Получение ID выбранной записи
                measurementId = (int)dgvMeasurement.Rows[e.RowIndex].Cells["ID"].Value;

                // Загрузка подробной информации о выбранной записи из базы данных
                var measurement = _context.Measurements
                    .FirstOrDefault(m => m.ID == measurementId);

                // Отображение подробной информации в других гридах
                if (measurement != null)
                {
                    var geologicalObject = _context.GeologicalObjects
                        .FirstOrDefault(gm => gm.ID == measurement.GeologicalObjectID);

                    // Отображение информации об объекте измерения
                    dgvGeologicalObjects.DataSource = new[] { geologicalObject };

                    var measurementProtocol = _context.MeasurementProtocols
                        .FirstOrDefault(gm => gm.ID == measurement.MeasurementProtocolID);

                    // Отображение информации о протоколе измерения
                    dgvMeasurementProtocols.DataSource = new[] { measurementProtocol };
                }
            }
        }

        private bool isEdit = false;

        private void btnAddMeasurement_Click(object sender, EventArgs e)
        {
            MeasurementForm form = new(_context);
            form.ShowDialog();
            LoadMeasurementData();
        }

        private void btnEditMeasurement_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if (measurementId != -1) // Убедитесь, что выбрана запись для редактирования
            {
                MeasurementForm form = new(_context, isEdit, measurementId);
                form.ShowDialog();
                LoadMeasurementData();
            }
            else
            {
                MessageBox.Show("Выберите запись для редактирования.");
            }
            isEdit = false;
        }

        int geologicalObjectsId = -1;
        private void dgvGeologicalObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGeologicalObjects.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                // Получение ID выбранной записи из dgvMeasurementProtocols
                geologicalObjectsId = (int)dgvGeologicalObjects.Rows[e.RowIndex].Cells["ID"].Value;
            }
        }

        private void btnAddGeologicalObjects_Click(object sender, EventArgs e)
        {
            GeologicalObjectsForm form = new(_context);
            form.ShowDialog();
            LoadMeasurementData();
        }

        private void btnEditGeologicalObjects_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if (geologicalObjectsId != -1)
            {
                GeologicalObjectsForm form = new(_context, isEdit, geologicalObjectsId);
                form.ShowDialog();
                LoadMeasurementData();
            }
            else
            {
                MessageBox.Show("Выберите строчку для изменения");
            }
            isEdit = false;
        }

        int measurementProtocolId = -1;
        private void dgvMeasurementProtocols_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMeasurementProtocols.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                // Получение ID выбранной записи из dgvMeasurementProtocols
                measurementProtocolId = (int)dgvMeasurementProtocols.Rows[e.RowIndex].Cells["ID"].Value;
            }
        }

        private void btnAddMeasurementProtocols_Click(object sender, EventArgs e)
        {
            MeasurementProtocolsForm form = new(_context);
            form.ShowDialog();
            LoadMeasurementData();
        }

        private void btnEditMeasurementProtocols_Click(object sender, EventArgs e)
        {
            isEdit = true;
            if (measurementProtocolId != -1)
            {
                MeasurementProtocolsForm form = new(_context, isEdit, measurementProtocolId);
                form.ShowDialog();
                LoadMeasurementData();
            }
            else
            {
                MessageBox.Show("Выберите строчку для изменения");
            }
            isEdit = false;
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            GraphForm graph = new(_context);
            graph.Show();
        }

        private void ConfigureGridColumns()
        {
            // Настройка колонок грида
            dgvGeologicalObjects.AutoGenerateColumns = false;
            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID"
            });
            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Name",
                DataPropertyName = "Name"
            });

            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Type",
                HeaderText = "Type",
                DataPropertyName = "Type"
            });
            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Depth",
                HeaderText = "Depth",
                DataPropertyName = "Depth"
            });
            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "XCoordinates",
                HeaderText = "XCoordinates",
                DataPropertyName = "XCoordinates"
            });
            dgvGeologicalObjects.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "YCoordinates",
                HeaderText = "YCoordinates",
                DataPropertyName = "YCoordinates"
            });

            dgvMeasurement.AutoGenerateColumns = false;
            dgvMeasurement.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID"
            });
            dgvMeasurement.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MeasurementProtocolID",
                HeaderText = "MeasurementProtocolID",
                DataPropertyName = "MeasurementProtocolID"
            });
            dgvMeasurement.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "GeologicalObjectID",
                HeaderText = "GeologicalObjectID",
                DataPropertyName = "GeologicalObjectID"
            });

            dgvMeasurementProtocols.AutoGenerateColumns = false;
            dgvMeasurementProtocols.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                DataPropertyName = "ID"
            });
            dgvMeasurementProtocols.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MeasurementDate",
                HeaderText = "MeasurementDate",
                DataPropertyName = "MeasurementDate"
            });
            dgvMeasurementProtocols.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Parameter",
                HeaderText = "Parameter",
                DataPropertyName = "Parameter"
            });
            dgvMeasurementProtocols.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EquipmentID",
                HeaderText = "EquipmentID",
                DataPropertyName = "EquipmentID"
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Close();
        }
    }
}

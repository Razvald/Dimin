using LogProject.Database;

namespace LogProject.DialogForm
{
    public partial class MeasurementProtocolsForm : Form
    {
        private readonly AppDbContext _dbContext;
        private int _measurementProtocolId;
        private bool _isEdit;

        public MeasurementProtocolsForm(AppDbContext dbContext, bool isEdit = false, int measurementProtocolId = -1)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _isEdit = isEdit;
            _measurementProtocolId = measurementProtocolId;

            FillComboBoxes();
            if (_isEdit)
                LoadExistingData(_measurementProtocolId);
        }

        private void FillComboBoxes()
        {
            foreach (var equip in _dbContext.Equipments)
            {
                cmbEquipment.Items.Add($"{equip.Name} (ID: {equip.ID})");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Заполните все данные");
                return;
            }

            try
            {
                if (_isEdit)
                {
                    var measurementProtocol = _dbContext.MeasurementProtocols.FirstOrDefault(mp => mp.ID == _measurementProtocolId);
                    if (measurementProtocol != null)
                    {
                        measurementProtocol.MeasurementDate = dtpDate.Value;
                        measurementProtocol.Parameter = Convert.ToInt32(txbParameter.Text);
                        measurementProtocol.EquipmentID = GetIDFromComboBox();

                        _dbContext.SaveChanges();

                        MessageBox.Show("Изменения сохранены.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Протокол измерения не найден.");
                    }
                }
                else
                {
                    var measurementProtocol = new MeasurementProtocol
                    {
                        MeasurementDate = dtpDate.Value,
                        Parameter = Convert.ToInt32(txbParameter.Text),
                        EquipmentID = GetIDFromComboBox()
                    };

                    _dbContext.MeasurementProtocols.Add(measurementProtocol);
                    _dbContext.SaveChanges();

                    MessageBox.Show("Запись создана.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании проекта: {ex?.InnerException?.Message}");
            }
        }

        private void LoadExistingData(int measurementProtocolId)
        {
            var existingProtocol = _dbContext.MeasurementProtocols.FirstOrDefault(mp => mp.ID == measurementProtocolId);
            if (existingProtocol != null)
            {
                dtpDate.Value = existingProtocol.MeasurementDate;
                txbParameter.Text = existingProtocol.Parameter.ToString();

                // Выбор оборудования в ComboBox
                cmbEquipment.SelectedIndex = cmbEquipment.FindStringExact($"{existingProtocol.Equipment.Name} (ID: {existingProtocol.EquipmentID})");
            }
        }

        private int GetIDFromComboBox()
        {
            string selectedMeasurement = cmbEquipment.SelectedItem.ToString();
            int startIndex = selectedMeasurement.IndexOf("(ID: ") + 5;
            int endIndex = selectedMeasurement.IndexOf(")");
            string measurementIDString = selectedMeasurement.Substring(startIndex, endIndex - startIndex);
            return int.Parse(measurementIDString);
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbParameter.Text) &&
                   cmbEquipment.SelectedItem != null;
        }
    }
}

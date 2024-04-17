using LogProject.Database;
using System.Data.Common;

namespace LogProject.DialogForm
{
    public partial class MeasurementForm : Form
    {
        private readonly AppDbContext _dbContext;
        private int _measurementId;
        private bool _isEdit;

        public MeasurementForm(AppDbContext dbContext, bool isEdit = false, int measurementId = -1)
        {
            InitializeComponent();
            _isEdit = isEdit;
            _measurementId = measurementId;
            _dbContext = dbContext;

            FillComboBoxes();
            if (_isEdit)
                LoadExistingData(_measurementId);
        }

        private void FillComboBoxes()
        {
            foreach (var equip in _dbContext.MeasurementProtocols)
            {
                cmbMeasurementProtocol.Items.Add($"(ID: {equip.ID})");
            }

            foreach (var equip in _dbContext.GeologicalObjects)
            {
                cmbGeologicalObject.Items.Add($"{equip.Name} (ID: {equip.ID})");
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
                    // Редактирование существующей записи
                    var measurement = _dbContext.Measurements.FirstOrDefault(m => m.ID == _measurementId);
                    if (measurement != null)
                    {
                        measurement.MeasurementProtocolID = GetIDFromComboBox(cmbMeasurementProtocol);
                        measurement.GeologicalObjectID = GetIDFromComboBox(cmbGeologicalObject);

                        _dbContext.SaveChanges();
                        MessageBox.Show("Запись успешно изменена.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось найти запись для редактирования.");
                    }
                }
                else
                {
                    var measurement = new Measurement
                    {
                        MeasurementProtocolID = GetIDFromComboBox(cmbMeasurementProtocol),
                        GeologicalObjectID = GetIDFromComboBox(cmbGeologicalObject),
                    };

                    _dbContext.Measurements.Add(measurement);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Запись успешно создана.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании проекта: {ex?.InnerException?.Message}");
            }
        }

        private void LoadExistingData(int measurementId)
        {
            var measurement = _dbContext.Measurements.FirstOrDefault(m => m.ID == measurementId);
            if (measurement != null)
            {
                // Установка значений полей формы на основе выбранной записи
                cmbMeasurementProtocol.SelectedItem = $"(ID: {measurement.MeasurementProtocolID})";
                cmbGeologicalObject.SelectedItem = $"{measurement.GeologicalObject.Name} (ID: {measurement.GeologicalObjectID})";
            }
        }

        private int GetIDFromComboBox(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();
            int startIndex = selected.IndexOf("(ID: ") + 5;
            int endIndex = selected.IndexOf(")");
            string IDString = selected.Substring(startIndex, endIndex - startIndex);
            return int.Parse(IDString);
        }

        private bool AreAllFieldsFilled()
        {
            return cmbGeologicalObject.SelectedItem != null &&
                   cmbMeasurementProtocol.SelectedItem != null;
        }
    }
}

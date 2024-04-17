using LogProject.Database;
using System.Xml.Linq;

namespace LogProject.DialogForm
{
    public partial class GeologicalObjectsForm : Form
    {

        private readonly AppDbContext _dbContext;
        private int _geologicalObjectsId;
        private bool _isEdit;

        public GeologicalObjectsForm(AppDbContext dbContext, bool isEdit = false, int geologicalObjectsId = -1)
        {
            InitializeComponent();
            _isEdit = isEdit;
            _geologicalObjectsId = geologicalObjectsId;
            _dbContext = dbContext;

            FillComboBoxes();
            if (_isEdit)
                LoadExistingData(_geologicalObjectsId);
        }

        private void FillComboBoxes()
        {
            // Заполнение комбобокса значениями из перечисления ObjectType
            foreach (ObjectType type in Enum.GetValues(typeof(ObjectType)))
            {
                cmbType.Items.Add(type.ToString());
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
                    var geologicalObject = _dbContext.GeologicalObjects.FirstOrDefault(g => g.ID == _geologicalObjectsId);
                    if (geologicalObject != null)
                    {
                        geologicalObject.Name = txbName.Text;
                        string selectedType = cmbType.SelectedItem.ToString();
                        if (Enum.TryParse(selectedType, out ObjectType type))
                        {
                            geologicalObject.Type = type;
                        }
                        geologicalObject.Depth = Convert.ToInt32(txbDepth.Text);
                        geologicalObject.XCoordinates = Convert.ToInt32(txbXCoordinates.Text);
                        geologicalObject.YCoordinates = Convert.ToInt32(txbYCoordinates.Text);

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
                    ObjectType types = ObjectType.Fossil;
                    string selectedType = cmbType.SelectedItem.ToString();
                    if (Enum.TryParse(selectedType, out ObjectType type))
                    {
                        types = type;
                    }
                    // Создание новой записи
                    var geologicalObject = new GeologicalObject
                    {
                        Name = txbName.Text,
                        Type = types,
                        Depth = Convert.ToInt32(txbDepth.Text),
                        XCoordinates = Convert.ToInt32(txbXCoordinates.Text),
                        YCoordinates = Convert.ToInt32(txbYCoordinates.Text)
                    };

                    _dbContext.GeologicalObjects.Add(geologicalObject);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Запись успешно создана.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании проекта: {ex?.Message}");
            }
        }

        private bool AreAllFieldsFilled()
        {
            return !string.IsNullOrEmpty(txbName.Text) &&
                   cmbType.SelectedItem != null &&
                   !string.IsNullOrEmpty(txbDepth.Text) &&
                   !string.IsNullOrEmpty(txbXCoordinates.Text) &&
                   !string.IsNullOrEmpty(txbYCoordinates.Text);
        }

        private void LoadExistingData(int geologicalObjectsId)
        {
            // Найти объект GeologicalObject с заданным идентификатором
            var geologicalObject = _dbContext.GeologicalObjects.FirstOrDefault(g => g.ID == geologicalObjectsId);

            // Заполнить соответствующие элементы управления данными из найденного объекта
            if (geologicalObject != null)
            {
                txbName.Text = geologicalObject.Name;
                txbDepth.Text = geologicalObject.Depth.ToString();
                txbXCoordinates.Text = geologicalObject.XCoordinates.ToString();
                txbYCoordinates.Text = geologicalObject.YCoordinates.ToString();
                cmbType.SelectedItem = geologicalObject.Type.ToString();
            }
        }
    }
}

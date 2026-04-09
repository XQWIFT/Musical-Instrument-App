using MusicInstrumentsApp.Models;
using System.Text.Json;
using System.Xml.Serialization;

namespace MusicInstrumentsApp
{
    public partial class MainForm : Form
    {
        private MusicCatalog? catalog = null;
        private string? loadedFormat = null; // "xml" или "json"
        private Instrument? selectedInstrument = null;

        public MainForm()
        {
            InitializeComponent();

            dataGridOfInstruments.MultiSelect = false;
            dataGridOfInstruments.EnableHeadersVisualStyles = false;
            dataGridOfInstruments.SelectionChanged += DataGridOfInstruments_SelectionChanged!;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            dialog.Title = "Выберите файл с каталогом";
            dialog.Filter = "XML файлы (*.xml)|*.xml|JSON файлы (*.json)|*.json";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                string path = dialog.FileName;
                string ext = Path.GetExtension(path).ToLower();

                if (ext == ".xml")
                {
                    var serializer = new XmlSerializer(typeof(XmlCatalogWrapper));
                    using var stream = File.OpenRead(path);
                    var wrapper = (XmlCatalogWrapper?)serializer.Deserialize(stream);
                    catalog = wrapper?.ToCatalog();
                    loadedFormat = "xml";
                }
                else if (ext == ".json")
                {
                    string json = File.ReadAllText(path);
                    var wrapper = JsonSerializer.Deserialize<JsonRootWrapper>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                    catalog = wrapper?.MusicCatalog;
                    loadedFormat = "json";
                }

                if (catalog == null || catalog.Instruments.Count == 0)
                {
                    MessageBox.Show("Файл загружен, но данные не найдены.",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadTree();
                LoadGrid(catalog.Instruments);

                buttonShow.Enabled = true;

                MessageBox.Show($"Загружено {catalog.Instruments.Count} инструментов ({loadedFormat!.ToUpper()})",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTree()
        {
            treeViewCatalog.Nodes.Clear();
            if (catalog == null) return;

            var byCategory = catalog.Instruments
                .GroupBy(i => i.Category.Name);

            foreach (var group in byCategory)
            {
                var categoryNode = new TreeNode(group.Key);

                foreach (var instrument in group)
                {
                    var instrumentNode = new TreeNode(instrument.Name)
                    {
                        Tag = instrument
                    };
                    categoryNode.Nodes.Add(instrumentNode);
                }

                treeViewCatalog.Nodes.Add(categoryNode);
            }

            treeViewCatalog.ExpandAll();
        }

        private void LoadGrid(List<Instrument> instruments)
        {
            dataGridOfInstruments.DataSource = null;
            dataGridOfInstruments.DataSource = instruments
                .Select(i => new
                {
                    ID = i.Id,
                    Название = i.Name,
                    Категория = i.Category.Name,
                    Производитель = i.Manufacturer.Name,
                    Цена = i.Price,
                    Наличие = i.InStock ? "Есть" : "Нет"
                })
                .ToList();
        }

        private void treeViewCatalog_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (catalog == null) return;

            if (e.Node?.Tag is Instrument instrument)
            {
                LoadGrid(catalog.Instruments.Where(i => i.Id == instrument.Id).ToList());
            }
            else if (e.Node?.Parent == null)
            {
                // Выбрана категория — показываем все инструменты категории
                string categoryName = e.Node!.Text;
                LoadGrid(catalog.Instruments.Where(i => i.Category.Name == categoryName).ToList());
            }
        }

        private void dataGridOfInstruments_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridOfInstruments.Rows.Count)
            {
                dataGridOfInstruments.ClearSelection();
                dataGridOfInstruments.Rows[e.RowIndex].Selected = true;
                dataGridOfInstruments.CurrentCell =
                    dataGridOfInstruments.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (catalog == null) return;

                int id = (int)dataGridOfInstruments.Rows[e.RowIndex].Cells["ID"].Value!;
                selectedInstrument = catalog.Instruments.FirstOrDefault(i => i.Id == id);
            }
        }

        private void DataGridOfInstruments_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (selectedInstrument == null)
            {
                MessageBox.Show("Выберите инструмент в таблице.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detailForm = new InstrumentDetailForm(selectedInstrument);
            detailForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
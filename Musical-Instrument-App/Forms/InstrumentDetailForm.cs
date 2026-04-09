using MusicInstrumentsApp.Models;
using System.Reflection.Emit;

namespace MusicInstrumentsApp
{
    /// <summary>
    /// Просмотр полной информации об инструменте
    /// </summary>
    public partial class InstrumentDetailForm : Form
    {
        public InstrumentDetailForm(Instrument instrument)
        {
            InitializeComponent();
            FillData(instrument);
        }

        private void FillData(Instrument instrument)
        {
            labelId.Text = $"ID: {instrument.Id}";
            labelName.Text = $"Название: {instrument.Name}";
            labelPrice.Text = $"Цена: {instrument.Price:N0} руб.";
            labelInStock.Text = $"Наличие: {(instrument.InStock ? "Есть на складе" : "Нет в наличии")}";
            labelCategory.Text = $"Категория: {instrument.Category.Name} (ID: {instrument.Category.Id})";
            labelManufacturer.Text = $"Производитель: {instrument.Manufacturer.Name} (ID: {instrument.Manufacturer.Id})";
            labelCountry.Text = $"Страна: {instrument.Manufacturer.Country}";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
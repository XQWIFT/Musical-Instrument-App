namespace MusicInstrumentsApp
{
    partial class InstrumentDetailForm
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
            labelTitle = new Label();
            labelId = new Label();
            labelName = new Label();
            labelPrice = new Label();
            labelInStock = new Label();
            labelCategory = new Label();
            labelManufacturer = new Label();
            labelCountry = new Label();
            buttonBack = new Button();
            SuspendLayout();

            // labelTitle
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 12);
            labelTitle.Size = new Size(460, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Text = "Информация об инструменте";

            // labelId
            labelId.Font = new Font("Segoe UI", 12F);
            labelId.Location = new Point(12, 65);
            labelId.Size = new Size(460, 30);
            labelId.Name = "labelId";

            // labelName
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(12, 100);
            labelName.Size = new Size(460, 30);
            labelName.Name = "labelName";

            // labelPrice
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(12, 135);
            labelPrice.Size = new Size(460, 30);
            labelPrice.Name = "labelPrice";

            // labelInStock
            labelInStock.Font = new Font("Segoe UI", 12F);
            labelInStock.Location = new Point(12, 170);
            labelInStock.Size = new Size(460, 30);
            labelInStock.Name = "labelInStock";

            // labelCategory
            labelCategory.Font = new Font("Segoe UI", 12F);
            labelCategory.Location = new Point(12, 220);
            labelCategory.Size = new Size(460, 30);
            labelCategory.Name = "labelCategory";

            // labelManufacturer
            labelManufacturer.Font = new Font("Segoe UI", 12F);
            labelManufacturer.Location = new Point(12, 270);
            labelManufacturer.Size = new Size(460, 30);
            labelManufacturer.Name = "labelManufacturer";

            // labelCountry
            labelCountry.Font = new Font("Segoe UI", 12F);
            labelCountry.Location = new Point(12, 305);
            labelCountry.Size = new Size(460, 30);
            labelCountry.Name = "labelCountry";

            // buttonBack
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(12, 360);
            buttonBack.Size = new Size(460, 45);
            buttonBack.Name = "buttonBack";
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click!;

            // Form
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 425);
            Controls.Add(labelTitle);
            Controls.Add(labelId);
            Controls.Add(labelName);
            Controls.Add(labelPrice);
            Controls.Add(labelInStock);
            Controls.Add(labelCategory);
            Controls.Add(labelManufacturer);
            Controls.Add(labelCountry);
            Controls.Add(buttonBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InstrumentDetailForm";
            Text = "Карточка инструмента";
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Label labelId;
        private Label labelName;
        private Label labelPrice;
        private Label labelInStock;
        private Label labelCategory;
        private Label labelManufacturer;
        private Label labelCountry;
        private Button buttonBack;
    }
}
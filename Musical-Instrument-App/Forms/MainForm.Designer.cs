namespace MusicInstrumentsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainerMain = new SplitContainer();
            pictureBoxLogo = new PictureBox();
            treeViewCatalog = new TreeView();
            panelTop = new Panel();
            buttonLoad = new Button();
            buttonShow = new Button();
            buttonClose = new Button();
            dataGridOfInstruments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOfInstruments).BeginInit();
            SuspendLayout();

            // splitContainerMain
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.FixedPanel = FixedPanel.Panel1;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            splitContainerMain.SplitterDistance = 180;
            splitContainerMain.Size = new Size(900, 600);

            // Panel1 (левая) — картинка + дерево
            splitContainerMain.Panel1.Controls.Add(treeViewCatalog);
            splitContainerMain.Panel1.Controls.Add(pictureBoxLogo);

            // Panel2 (правая) — кнопки + таблица
            splitContainerMain.Panel2.Controls.Add(dataGridOfInstruments);
            splitContainerMain.Panel2.Controls.Add(panelTop);

            // pictureBoxLogo
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Height = 120;
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.Image = Image.FromFile("logo.png");

            // treeViewCatalog
            treeViewCatalog.Dock = DockStyle.Fill;
            treeViewCatalog.Font = new Font("Segoe UI", 11F);
            treeViewCatalog.Name = "treeViewCatalog";
            treeViewCatalog.AfterSelect += treeViewCatalog_AfterSelect!;

            // panelTop — кнопки сверху
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 55;
            panelTop.Name = "panelTop";
            panelTop.Controls.Add(buttonClose);
            panelTop.Controls.Add(buttonShow);
            panelTop.Controls.Add(buttonLoad);

            // buttonLoad
            buttonLoad.Font = new Font("Segoe UI", 12F);
            buttonLoad.Location = new Point(5, 8);
            buttonLoad.Size = new Size(180, 40);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Text = "Загрузить";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click!;

            // buttonShow
            buttonShow.Font = new Font("Segoe UI", 12F);
            buttonShow.Location = new Point(195, 8);
            buttonShow.Size = new Size(180, 40);
            buttonShow.Name = "buttonShow";
            buttonShow.Text = "Показать";
            buttonShow.Enabled = false;
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click!;

            // buttonClose
            buttonClose.Font = new Font("Segoe UI", 12F);
            buttonClose.Location = new Point(385, 8);
            buttonClose.Size = new Size(180, 40);
            buttonClose.Name = "buttonClose";
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click!;

            // dataGridOfInstruments
            dataGridOfInstruments.AllowUserToAddRows = false;
            dataGridOfInstruments.AllowUserToDeleteRows = false;
            dataGridOfInstruments.AllowUserToResizeColumns = false;
            dataGridOfInstruments.AllowUserToResizeRows = false;
            dataGridOfInstruments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOfInstruments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOfInstruments.Dock = DockStyle.Fill;
            dataGridOfInstruments.ReadOnly = true;
            dataGridOfInstruments.RowHeadersVisible = false;
            dataGridOfInstruments.Name = "dataGridOfInstruments";
            dataGridOfInstruments.CellMouseClick += dataGridOfInstruments_CellMouseClick!;

            // MainForm
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(splitContainerMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Музыкальные инструменты";

            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOfInstruments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainerMain;
        private PictureBox pictureBoxLogo;
        private TreeView treeViewCatalog;
        private Panel panelTop;
        private Button buttonLoad;
        private Button buttonShow;
        private Button buttonClose;
        private DataGridView dataGridOfInstruments;
    }
}

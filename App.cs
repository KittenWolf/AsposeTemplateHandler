using AsposeTemplateHandler.Abstractions;
using AsposeTemplateHandler.DataSources;
using System;
using System.Windows.Forms;

namespace AsposeTemplateHandler
{
    public partial class App : Form
    {
        private DataSource _dataSource;

        public App()
        {
            InitializeComponent();
        }

        private void SelectTemplateBtn_Click(object sender, EventArgs e)
        {
            TemplateFileDialog.ShowDialog(this);

            TemplatePath.Text = TemplateFileDialog.FileName;
        }

        private void LocalDbOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Checked)
                {
                    _dataSource = new LocalDbSource(DataGridView);
                    _dataSource.UpdateDataGridView();
                }
            }
        }

        private void WordOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Checked)
                {
                    var openFileDialog = new OpenFileDialog();
                    openFileDialog.ShowDialog(this);

                    _dataSource = new WordSource(openFileDialog.FileName, DataGridView);
                    _dataSource.UpdateDataGridView();
                }
            }
        }

        private void ExcelOption_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Checked)
                {
                    //_dataSource = new WordSource(DataGridView);
                    //_dataSource.UpdateDataGridView();
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFolderBrowserDialog.ShowDialog(this);

            var saveDir = SaveFolderBrowserDialog.SelectedPath;
            var selectedRowsCount = DataGridView.SelectedRows.Count;
            
            var handler = new TemplateHandler();

            for (int i = 0; i < selectedRowsCount; i++)
            {
                var data = _dataSource.GetRow(i);

                handler.FillTemplate(TemplatePath.Text, data, saveDir);
            }
        }
    }
}

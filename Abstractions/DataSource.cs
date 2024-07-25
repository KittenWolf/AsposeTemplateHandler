using System.Collections.Generic;
using System.Windows.Forms;

namespace AsposeTemplateHandler.Abstractions
{
    internal abstract class DataSource
    {
        private readonly DataGridView _dataGrid;

        public DataSource(DataGridView dataGrid)
        {
            _dataGrid = dataGrid;
        }

        protected List<string> Columns { get; } = new List<string>();
        protected List<string[]> Rows { get; } = new List<string[]>();

        private void ResetDataGrid()
        {
            Columns.Clear();
            Rows.Clear();

            _dataGrid.Columns.Clear();
            _dataGrid.Rows.Clear();
        }

        protected abstract void GetData();

        public Dictionary<string, string> GetRow(int i)
        {
            var keyValuePairs = new Dictionary<string, string>();

            for (int j = 0; j < Rows[i].Length; j++)
            {
                keyValuePairs.Add(Columns[j], Rows[i][j]);
            }

            return keyValuePairs;
        }

        public void UpdateDataGridView()
        {
            ResetDataGrid();
            GetData();

            foreach (var item in Columns)
            {
                _dataGrid.Columns.Add(item, item);
            }

            foreach (var item in Rows)
            {
                _dataGrid.Rows.Add(item);
            }
        }
    }
}

using Aspose.Words;
using Aspose.Words.Tables;
using AsposeTemplateHandler.Abstractions;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AsposeTemplateHandler.DataSources
{
    internal class WordSource : DataSource
    {
        private readonly string _sourcePath;

        public WordSource(string sourcePath, DataGridView dataGrid) 
            : base(dataGrid)
        {
            _sourcePath = sourcePath;
        }

        protected override void GetData()
        {
            Document doc = new Document(_sourcePath);

            var tables = doc.FirstSection.Body.Tables;

            foreach (var table in tables.Cast<Table>())
            {
                var data = new string[table.Rows.Count - 1];

                for (int i = 1; i < table.Rows.Count; i++)
                {
                    var row = table.Rows[i];
                    var cell = row.FirstCell;
                    var key = cell.Range.Text.Split('_')[1];

                    var match = Regex.Match(key, @"\w+");

                    Columns.Add(match.Value);

                    //var value = cell.NextCell.Range.Text.Split('\\')[0];
                    var value = Regex.Replace(cell.NextCell.Range.Text, @"[^\w\.@+-]", "");
                    data[i - 1] = value;
                }

                Rows.Add(data);
            }
        }
    }
}

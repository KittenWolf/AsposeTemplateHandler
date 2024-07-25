using AsposeTemplateHandler.Abstractions;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsposeTemplateHandler.DataSources
{
    internal class LocalDbSource : DataSource
    {
        public LocalDbSource(DataGridView dataGrid)
            : base(dataGrid)
        {
        }

        protected override void GetData()
        {
            var connectionString = Properties.Settings.Default.LocalDbConnectionString;
            var connection = new SqlConnection(connectionString);

            connection.Open();
            
            var reader = SelectData(connection);
            var fieldsCount = reader.FieldCount;

            for (int i = 0; i < fieldsCount; i++)
            {
                Columns.Add(reader.GetName(i));
            }

            while (reader.Read())
            {
                var row = new string[fieldsCount];

                for (int i = 0; i < fieldsCount; i++)
                {
                    row[i] = $"{reader.GetValue(i)}";
                }

                Rows.Add(row);
            }

            reader.Close();
            connection.Close();
        }

        private SqlDataReader SelectData(SqlConnection connection)
        {
            var queryString = @"
                select 
                    [bt], 
                    [sn], 
                    format([year2], 'MM.yyyy') as year2, 
                    [fio], 
                    format([datepr], 'dd.MM.yyyy') as datepr, 
                    format([year1], 'yyyy') as year1
                from [GasAnalyzers]";

            var query = new SqlCommand(queryString, connection);

            return query.ExecuteReader();
        }
    }
}

using FastReport;
using System.Data;
using System.Reflection;

namespace Infrastructure.Reportig
{
    public class FastReport
    {
        public string GenerateReport(Infrastructure.Data.Entities.DocumentEntity document, List<Infrastructure.Data.Entities.ArticleEntity> articles)
        {
            try
            {
                var report = new Report();
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "document.frx");
                report.Load(path);
                var dataSet = new DataSet("Data");
                dataSet.Tables.Add(NewTable("Document", new List<Infrastructure.Data.Entities.DocumentEntity> { document }));
                dataSet.Tables.Add(NewTable("Articles", articles));
                report.RegisterData(dataSet, "Data");
                if (!report.Prepare())
                {
                    throw new Exception("Report Prepare did not work properly");
                }

                var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"documents/{document.Type}_{document.Client}_{DateTime.Now.ToString("yyyyMMdd HHmmssfff")}.pdf");
                new global::FastReport.Export.PdfSimple.PDFSimpleExport()
                            .Export(report, fileName);
                return fileName;
            }
            catch (Exception e)
            {
                return "";
                throw e;
            }
        }

        #region Helpers
        public static DataSet ConvertToDataSet<T>(IEnumerable<T> source, string name)
        {
            if (source == null)
                throw new ArgumentNullException("source");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            var converted = new DataSet(name);
            converted.Tables.Add(NewTable(name, source));
            return converted;
        }

        private static DataTable NewTable<T>(string name, IEnumerable<T> list)
        {
            PropertyInfo[] propInfo = typeof(T).GetProperties();
            DataTable table = Table<T>(name, list, propInfo);
            IEnumerator<T> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
                table.Rows.Add(CreateRow<T>(table.NewRow(), enumerator.Current, propInfo));
            return table;
        }

        private static DataRow CreateRow<T>(DataRow row, T listItem, PropertyInfo[] pi)
        {
            foreach (PropertyInfo p in pi)
                row[p.Name.ToString()] = p.GetValue(listItem, null);
            return row;
        }

        private static DataTable Table<T>(string name, IEnumerable<T> list, PropertyInfo[] pi)
        {
            DataTable table = new DataTable(name);
            foreach (PropertyInfo p in pi)
                table.Columns.Add(p.Name, p.PropertyType);
            return table;
        }
        #endregion
    }
}
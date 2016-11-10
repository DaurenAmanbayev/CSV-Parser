using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser
{
    class TextField
    {
        public List<TextRow> _rowsList { get; set; }
        
        public int _columnsMaxCount { get; set; }

        public void ReadSeparatedText(string filename, char trimSymbol, char separator)
        {
            String[] lines = File.ReadAllLines(filename, Encoding.GetEncoding(1251));

            foreach (var line in lines)
            {
                TextRow row=new TextRow();
                row.AddRow(line, separator);
                row.TrimData(trimSymbol);
                //если у нас имеется значение максимального количества строк, сравниваем его
                if (_columnsMaxCount != null && _columnsMaxCount<row._RowData.Length)
                {
                    _columnsMaxCount = row._RowData.Length;
                }
                else
                {
                    //если его нет, инициализируем
                    _columnsMaxCount = row._RowData.Length;
                }
                _rowsList.Add(row);
            }
        }

        public void WriteSeparatedText(string filename, string separator)
        {
            List<string> content=new List<string>(_rowsList.Count);
            foreach (var row in _rowsList)
            {
                content.Add(row.RowStr(separator));
            }
            File.WriteAllLines(filename, content);
        }
    }
}

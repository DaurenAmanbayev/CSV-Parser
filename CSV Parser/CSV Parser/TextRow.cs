using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser
{
    class TextRow
    {
        public string[] _RowData { private set; get; }
     

        public void AddRow(string rowStr, char separator)
        {
            _RowData = rowStr.Split(separator);
        }

        public void TrimData(char trimSymbol)
        {
            for (int i = 0; i < _RowData.Length; i++)
            {
                _RowData[i] = _RowData[i].Trim(trimSymbol);
            }
        }

        public string RowStr(string separator)
        {
            return string.Join(separator, _RowData);
        }
    }
    

}

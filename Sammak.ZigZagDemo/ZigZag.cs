using System;
using System.Collections.Generic;

namespace Sammak.ZigZagDemo
{
    public class ZigZag
    {
        public string InputText { get; set; }
        public int Rows { get; set; }
        public List<Column> Columns { get; } = new List<Column>();

        public string GenerateOutputString()
        {
            int columnIndex = 0;
            var filledChars = 0;
            while (filledChars < InputText.Length)
            {
                var column = new Column(Rows, columnIndex++, InputText, filledChars);
                filledChars += column.CharacterCount();
                Columns.Add(column);
            }

            var output = string.Empty;
            for (var row = 0; row < Rows; row++)
            {
                output += GetChars(row) + Environment.NewLine;
            }
            return output;
        }

        internal string GetChars(int row)
        {
            var output = string.Empty;
            for (var i = 0; i < Columns.Count; i++)
            {
                var column = Columns[i];
                output += column.GetCharacter(row);
            }
            return output;
        }

    }
}

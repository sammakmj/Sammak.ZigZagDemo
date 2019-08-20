using System.Collections.Generic;

namespace Sammak.ZigZagDemo
{
    public class Column
    {
        public Column(int rows, int columnIndex, string data, int dataIndex)
        {
            Rows = rows;
            ColumnIndex = columnIndex;
            IsVertical = ColumnIndex % (Rows - 1) == 0;

            Chars = new List<char>();
            for (int i = 0; i < Rows; i++)
            {
                Chars.Add(' ');
            }

            for (int i = 0; i < Rows; i++)
            {
                if (IsVertical)
                {
                    if (dataIndex < data.Length)
                    {
                        Chars[i] = data[dataIndex++];
                    }
                }
                else
                {
                    var columnOffset = columnIndex % (Rows - 1);
                    var idx = Rows - 1 - columnOffset;
                    if (i == idx)
                    {
                        if (dataIndex < data.Length)
                        {
                            Chars[i] = data[dataIndex++];
                        }
                    }
                }
            }
        }

        public int Rows { get; private set; }
        public int ColumnIndex { get; private set; }
        public List<char> Chars { get; private set; }
        public bool IsVertical { get; }

        internal int CharacterCount()
        {
            var count = 0;
            for (var i = 0; i < Rows; i++)
            {
                if (Chars[i] != ' ')
                    count++;
            }
            return count;
        }

        internal char GetCharacter(int row)
        {
            return Chars[row];
        }

    }
}

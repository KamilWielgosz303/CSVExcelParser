using System;
using System.Collections.Generic;
using System.Text;

namespace CSVExcelParser
{
    class InvalidCellFormatException : Exception
    {
        private new readonly string Message = "Invalid Cell Format";
        public string Group { get; }
        public InvalidCellFormatException(string Group)
        {
            this.Group = Group;
        }
        public override string ToString()
        {
            return Message;
        }
    }
}

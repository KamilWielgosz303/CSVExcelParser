using System;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace CSVExcelParser
{
    class GroupException : Exception
    {
        private new readonly string Message = "Invalid CSV group";
        
        public override string ToString()
        {
            return Message;
        }
    }
}

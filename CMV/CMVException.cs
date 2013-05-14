using System;
using System.Text;

namespace CMVData
{
    public class CMVException : Exception
    {
        private string _message;

        public CMVException()
        {
            _message = "";
        }

        public CMVException(string message)
        {
            _message = message;
        }

        public override string Message
        {
            get {return this._message;}
        }
    }
}

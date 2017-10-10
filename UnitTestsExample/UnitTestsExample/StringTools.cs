using System;

namespace UnitTestsExample
{
    public class StringTools
    {
        private string _originalString;

        public string OriginalString
        {
            get { return _originalString; }
            set { _originalString = value; }
        }

        public StringTools(string s)
        {
            _originalString = s;
        }

        public string InsertInto(int pos, string s)
        {
            string temp = "";
            for (int i = 0; i < pos-1; i++)
            {
                temp = temp + _originalString[i];
            }

            temp = temp + s;

            for (int i = pos-1; i < _originalString.Length; i++)
            {
                temp = temp + _originalString[i];
            }

            return temp;
        }
    }
}

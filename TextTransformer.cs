using System;
using System.Collections.Generic;
using System.Text;

namespace TaskString
{
    class TextTransformer
    {
        public string Transform(string s)
        {
            if (string.IsNullOrEmpty(s))
                return "Some value";
            else
            {
                StringBuilder res = new StringBuilder();
                foreach (char c in s)
                {
                    res.Append(Char.ToUpper(c));
                }
                return res.ToString();
            }
        }
    }
}

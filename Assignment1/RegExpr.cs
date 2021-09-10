using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach(var str in lines) {
                var output = Regex.Split(str, "[^a-zA-Z0-9\\d\\s:]");
                foreach(var str2 in output) {
                    if (!String.IsNullOrEmpty(str2)) {
                        yield return str2;
                    }
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}

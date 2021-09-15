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
            foreach (Match match in Regex.Matches(resolutions, @"(?<width>\d*)x(?<height>\d*)")) {
                var width = match.Groups["width"].Value;
                var height = match.Groups["height"].Value;

                yield return (Int32.Parse(width), Int32.Parse(height));
            } 
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            var regexOutput = string.Format(@"<[{0}][^>]*>(?<innertext>.+?)</[{0}]>", tag);
            foreach (Match match in Regex.Matches(html, regexOutput))
            {
                yield return Regex.Replace(match.Groups["innertext"].Value, "<[^>]*>", "");
            }
        }
    }
}

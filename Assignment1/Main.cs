using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Main
    {
        public static void main(string[] args) {
            var text = "hello!and!welcome";
            var output = text.Split("/[^A-Za-z0-9]/");

            foreach (var str in output) {
                Console.WriteLine(str);
            }
        }
    }
}

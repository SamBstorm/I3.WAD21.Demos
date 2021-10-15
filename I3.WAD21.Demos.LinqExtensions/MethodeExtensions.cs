using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3.WAD21.Demos.LinqExtensions.Test
{
    public static class MethodeExtensions
    {
        public static void ColoredWriteLine(this string text, ConsoleColor bgColor, ConsoleColor fgColor)
        {
            Console.ForegroundColor = fgColor;
            Console.BackgroundColor = bgColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}

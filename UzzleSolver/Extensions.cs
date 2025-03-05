using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzzleSolver;
public static class Extensions
{
    public static ConsoleColor ToConsoleColor(this UzzleColor color) => color switch
    {
        UzzleColor.Red => ConsoleColor.Red,
        UzzleColor.Green => ConsoleColor.Green,
        UzzleColor.Blue => ConsoleColor.Blue,
        UzzleColor.Purple => ConsoleColor.Magenta,
        UzzleColor.Yellow => ConsoleColor.Yellow,
        _ => ConsoleColor.Black,
    };
}

using ConsoleGeom.Lib.Shapes.Lines;
using System;
using ConsoleGeom.Lib;

namespace ConsoleGeom.CmdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VerticalLine line = new VerticalLine(new Point { X = 2, Y = 3 }, 5);
            line.Print();
        }
    }
}

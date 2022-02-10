﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeom.Lib.Shapes
{
    public abstract class Base : IMovable
    {
        public Point[] Points { get; init; } = null!;

        public abstract void Move(Point finish);

        public void Print(char symbol = '0')
        {
            foreach (var p in Points) p.Print(symbol);
        }
    }
}

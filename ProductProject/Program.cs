﻿using System;
using System.Collections.Generic;

namespace ProductProject {
    class Program {
        static void Main(string[] args) {

            /*
             * Write a program to calculate the price of:
             *   3 Bronse Widgets
             *   7 Silver Widgets
             *   9 Gold Widgets
             */
            var widgets = new List<IProduct>();
            for(var idx = 0; idx < 3; idx ++) {
                widgets.Add(new BronseWidget());
            }
            for(var idx2 = 0; idx2 < 7; idx2++) {
                widgets.Add(new SilverWidget());
            }
            for(var idx3 = 0; idx3 < 9; idx3++) {
                widgets.Add(new GoldWidget());
            }
            var total = 0.0;
            foreach(var widget in widgets) {
                total += widget.GetPrice();
            }
            Console.WriteLine($"Total is {total}");
        }
    }
}

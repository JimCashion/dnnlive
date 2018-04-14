using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dnn
{
    public class SecureStuff
    {
        // 1=north
        // 2=east
        // 3=south
        // 4=west
        // 5=east-noicon
        // 6=gap
        // 7=north-noicon
        // 8=west-noicon
        // 9=south-noicon

        public static string tab = "5161";
        public static string space = "51";
        public static string newline = "07";
        public static string period = "9321728171";
        public static string c1 = "51357581";
        public static string c2 = "3122324232228275";
        public static string c3 = "3122324252324275";
        public static string c4 = "33221292328275";
        public static string c5 = "5231423222324275";
        public static string c6 = "3522124272228271";
        public static string c7 = "3122347582";
        public static string c8 = "3322324211715212418171";
        public static string c9 = "337222324252324275";
        public static string c0 = "352214418171";

        public static string GetCoords(string game)
        {
            string a = "";

            switch (game)
            {
                
                case "G1":
                    // N51 39.004 W003 48.706
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c4 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c8 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c0 + tab;
                    a += c6 + tab;
                    break;
                case "G2":
                    // N51 39.706 W003 47.743
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c0 + tab;
                    a += c6 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c7 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c4 + tab;
                    a += c3 + tab;
                    break;
                case "G3":
                    // N51 39.904 W003 47.159
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c9 + tab;
                    a += c0 + tab;
                    a += c4 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c7 + tab;
                    a += period + tab;
                    a += c1 + tab;
                    a += c5 + tab;
                    a += c9 + tab;
                    break;
                case "G4":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c9 + tab;
                    a += c8 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c7 + tab;
                    a += period + tab;
                    a += c9 + tab;
                    a += c7 + tab;
                    a += c0 + tab;
                    break;
                case "G5":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c3 + tab;
                    a += c5 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c8 + tab;
                    a += period + tab;
                    a += c0 + tab;
                    a += c7 + tab;
                    a += c0 + tab;
                    break;
                case "G6":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c8 + tab;
                    a += c7 + tab;
                    a += c3 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c8 + tab;
                    a += period + tab;
                    a += c1 + tab;
                    a += c0 + tab;
                    a += c8 + tab;
                    break;
                case "G7":
                    // N51 39.xxx W003 47.xxx

                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c9 + tab;
                    a += c5 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c7 + tab;
                    a += period + tab;
                    a += c5 + tab;
                    a += c8 + tab;
                    a += c0 + tab;
                    break;
                case "G8":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c5 + tab;
                    a += c6 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c4 + tab;
                    a += c2 + tab;
                    a += c3 + tab;
                    break;
                case "G9":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c4 + tab;
                    a += c3 + tab;
                    a += c3 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c8 + tab;
                    a += period + tab;
                    a += c2 + tab;
                    a += c8 + tab;
                    a += c5 + tab;
                    break;
                case "Bonus":
                    // N51 39.xxx W003 47.xxx
                    a += tab;
                    a += c5 + tab;
                    a += c1 + tab;
                    a += space;
                    a += c3 + tab;
                    a += c9 + tab;
                    a += period + tab;
                    a += c4 + tab;
                    a += c0 + tab;
                    a += c4 + tab;
                    a += newline;
                    a += c0 + tab;
                    a += c0 + tab;
                    a += c3 + tab;
                    a += space;
                    a += c4 + tab;
                    a += c8 + tab;
                    a += period + tab;
                    a += c7 + tab;
                    a += c1 + tab;
                    a += c0 + tab;
                    break;
            }

            return a;
        }

    }
}

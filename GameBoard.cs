using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary
{
    public class GameBoard
    {
        public string hit { get; set; }
        public string miss { get; set; }
        public string ship { get; set; }
        private string[] rowA { get; set; }
        public string[] rowB { get; set; }
        public string[] rowC { get; set; }
        public string[] rowD { get; set; }
        public string[] rowE { get; set; }
        public string[] rowF { get; set; }
        public string[] rowG { get; set; }
        public string[] rowH { get; set; }
        public string[] rowI { get; set; }
        public string[] rowJ { get; set; }
        public string[] rowK { get; set; }
        public string[][] rows { get; set; }


        public GameBoard()
        {
            hit = "X";
            miss = "O";
            ship = "S";
            rowA = new string[] { "  ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            rowB = new string[] { " 1", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowC = new string[] { " 2", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowD = new string[] { " 3", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowE = new string[] { " 4", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowF = new string[] { " 5", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowG = new string[] { " 6", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowH = new string[] { " 7", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowI = new string[] { " 8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowJ = new string[] { " 9", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };
            rowK = new string[] { "10", " ", " ", " ", " ", " ", " ", " ", " ", " ", " " };

            rows = new string[][]{
             rowA,
             rowB,
             rowC,
             rowD,
             rowE,
             rowF,
             rowG,
             rowH,
             rowI,
             rowJ,
             rowK };
        }






        public static void pipe()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("|");
            Console.ResetColor();
        }
    }
}
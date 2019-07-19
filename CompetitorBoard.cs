using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLibrary
{
    public class CompetitorBoard : GameBoard
    {
        public override string ToString()
        {
            foreach (string[] sArray in rows)
            {
                foreach (string item in sArray)
                {
                    pipe();
                    if (item == hit)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(item);
                        Console.ResetColor();
                    }
                    else if (item == ship)
                        Console.Write(" ");
                    else
                        Console.Write(item);

                }
                pipe();
                Console.WriteLine();

            }
            return "";
        }
    }
}

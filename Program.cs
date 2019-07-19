using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipLibrary;

/*
 * Battlship!
 * Contributors: Jonathon, Takeshi, Alysha
 * 
 */
namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            CompetitorBoard gameBoard = new CompetitorBoard();
            Ship playerDestroyer = new Ship(7, 10, 8, 10);
            //Ship playerBattleship = new Ship(1,1,1,4);
            //Ship playerCruiser = new Ship(10,3,10,5);
            //Ship playerSubmarine = new Ship(5, 1, 5, 3);
            //Ship playerCarrier = new Ship(4, 5, 8, 5);

            bool exit = true;

            do
            {
                Console.WriteLine("Do you want to play BattleShip? Y/N");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                bool reload = false;

                switch (userChoice)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine("Welcome to BattleShip!");
                        //TODO Build BAttle()
                        //Console.WriteLine("Enter letter from A-J: ");
                        //ConsoleKey userLetter = Console.ReadKey(true).Key;
                        //Console.WriteLine("Enter a number from 1-0 (0 = 10): ");
                        //ConsoleKey userNumber = Console.ReadKey(true).Key;
                        //switch (userLetter & userNumber)
                        //{


                        //    default:
                        //        Console.WriteLine("That is not a valid option. Enter another value.");
                        //        break;
                        //}
                        //AddShip(gameBoard, playerCarrier);
                        //AddShip(gameBoard, playerBattleship);
                        //AddShip(gameBoard, playerCruiser);
                        //AddShip(gameBoard, playerSubmarine);
                        AddShip(gameBoard, playerDestroyer);
                        while (!reload)
                        {
                            Console.Clear();
                            Console.WriteLine(gameBoard);

                            //Console.WriteLine("Enter first coord: (A2)");
                            //Ship newship = new Ship(getCoord(), getCoord());
                            //AddShip(gameBoard,newship);
                            //Console.WriteLine(gameBoard);
                            Console.WriteLine("Enter coords to attack: (A2)");
                            Attack(gameBoard);
                            if (WinCheck(gameBoard))
                            {
                                Console.WriteLine("You Win!");
                                Console.ReadLine();
                            }
                            exit = !WinCheck(gameBoard);
                        }
                        exit = reload;
                        break;

                    case ConsoleKey.N:
                        Console.WriteLine("Good Bye");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, please choose again");
                        break;
                }//end switch
            } while (exit);







        }

        public static void AddShip(GameBoard gameboard, Ship newShip)
        {
            gameboard.rows[newShip.YPos1][newShip.XPos1] = gameboard.ship;
            if (newShip.YPos1 == newShip.YPos2)
            {
                for (int i = newShip.XPos1; i < newShip.XPos2; i++)
                {
                    gameboard.rows[newShip.YPos1][i] = gameboard.ship;
                }
            }
            else
            {
                for (int i = newShip.YPos1; i < newShip.YPos2; i++)
                {
                    gameboard.rows[i][newShip.XPos1] = gameboard.ship;
                }
            }
            gameboard.rows[newShip.YPos2][newShip.XPos2] = gameboard.ship;
        }
        static int[] getCoord()
        {
            int[] coords = new int[2];
            coords[0] = 1;
            ConsoleKey userKey = Console.ReadKey().Key;
            coords[1] = int.Parse(Console.ReadLine());
            if (coords[1] > 10)
                coords[1] = 10;
            else if (coords[1] < 1)
                coords[1] = 1;
            switch (userKey)
            {
                case ConsoleKey.A:
                    coords[0] = 1;
                    break;
                case ConsoleKey.B:
                    coords[0] = 2;
                    break;
                case ConsoleKey.C:
                    coords[0] = 3;
                    break;
                case ConsoleKey.D:
                    coords[0] = 4;
                    break;
                case ConsoleKey.E:
                    coords[0] = 5;
                    break;
                case ConsoleKey.F:
                    coords[0] = 6;
                    break;
                case ConsoleKey.G:
                    coords[0] = 7;
                    break;
                case ConsoleKey.H:
                    coords[0] = 8;
                    break;
                case ConsoleKey.I:
                    coords[0] = 9;
                    break;
                case ConsoleKey.J:
                    coords[0] = 10;
                    break;
                default:
                    break;
            }
            return coords;
        }
        static void Attack(GameBoard gameBoard)
        {
            int[] attackCoords = getCoord();
            if (gameBoard.rows[attackCoords[1]][attackCoords[0]] == gameBoard.ship)
            {
                gameBoard.rows[attackCoords[1]][attackCoords[0]] = gameBoard.hit;
            }
            else
            {
                gameBoard.rows[attackCoords[1]][attackCoords[0]] = gameBoard.miss;
            }

        }
        static bool WinCheck(GameBoard gameboard)
        {
            int ships = 0;
            foreach (string[] sArray in gameboard.rows)
            {
                foreach (string item in sArray)
                {
                    if (item == gameboard.ship)
                    {
                        ships++;
                    }
                }

            }
            return ships == 0 ? true : false;
        }
    }
}



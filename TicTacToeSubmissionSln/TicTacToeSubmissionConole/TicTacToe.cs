using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(30, 6);
            _boardRenderer.Render();
        }

        string[] topRow = { "", "", "" };
        string[] midRow = { "", "", "" };
        string[] bottRow = { "", "", "" };

        public void RunX()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);
            Console.Write("Prince You Chose X");

            Console.SetCursorPosition(2, 20);
            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);
            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

            if (int.Parse(row) == 0)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < topRow.Length; a++)
                    {
                        topRow[int.Parse(column)] = "a";
                    }
                    if (topRow[0] == "a" && topRow[1] == "a" && topRow[2] == "a")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (int.Parse(row) == 1)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < midRow.Length; a++)
                    {
                        midRow[int.Parse(column)] = "a";
                    }
                    if (midRow[0] == "a" && midRow[1] == "a" && midRow[2] == "a")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (int.Parse(row) == 2)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < bottRow.Length; a++)
                    {
                        bottRow[int.Parse(column)] = "a";
                    }
                    if (bottRow[0] == "a" && bottRow[1] == "a" && bottRow[2] == "a")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (topRow[0] == "a" && midRow[0] == "a" && bottRow[0] == "a")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[1] == "a" && midRow[1] == "a" && bottRow[1] == "a")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[2] == "a" && midRow[2] == "a" && bottRow[2] == "a")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[0] == "a" && midRow[1] == "a" && bottRow[2] == "a")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[2] == "a" && midRow[1] == "a" && bottRow[0] == "a")
            {
                Console.WriteLine(" You have won !");
            }

            RunO();
        }

        public void RunO()
        {
       

            Console.SetCursorPosition(2, 19);
            Console.Write("Player Onge Chose O");

            Console.SetCursorPosition(2, 20);
            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);
            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

            if (int.Parse(row) == 0)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < topRow.Length; a++)
                    {
                        topRow[int.Parse(column)] = "b";
                    }
                    if (topRow[0] == "b" && topRow[1] == "b" && topRow[2] == "b")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (int.Parse(row) == 1)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < midRow.Length; a++)
                    {
                        midRow[int.Parse(column)] = "b";
                    }
                    if (midRow[0] == "b" && midRow[1] == "b" && midRow[2] == "b")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (int.Parse(row) == 2)
            {
                if (int.Parse(column) == 0 || int.Parse(column) == 1 || int.Parse(column) == 2)
                {
                    for (int a = 0; a < bottRow.Length; a++)
                    {
                        bottRow[int.Parse(column)] = "b";
                    }
                    if (bottRow[0] == "b" && bottRow[1] == "b" && bottRow[2] == "b")
                    {
                        Console.WriteLine(" You have won !");
                    }
                }
            }

            if (topRow[0] == "b" && midRow[0] == "b" && bottRow[0] == "b")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[1] == "b" && midRow[1] == "b" && bottRow[1] == "b")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[2] == "b" && midRow[2] == "b" && bottRow[2] == "b")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[0] == "b" && midRow[1] == "b" && bottRow[2] == "b")
            {
                Console.WriteLine(" You have won !");
            }

            if (topRow[2] == "b" && midRow[1] == "b" && bottRow[0] == "b")
            {
                Console.WriteLine(" You have won !");
            }

            RunX();

        }

    }
}


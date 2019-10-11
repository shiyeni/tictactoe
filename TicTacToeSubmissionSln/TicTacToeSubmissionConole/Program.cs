﻿using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;

            Console.SetCursorPosition(10,2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Let You Play :-) Don't Be Rude Ok");

            var ticTacToe = new TicTacToe();

            ticTacToe.RunX();

            ticTacToe.RunO();
            Console.ForegroundColor = oldColor ;


            Console.SetCursorPosition(20, 25);
            Console.ReadLine();

            
        }

    }
}

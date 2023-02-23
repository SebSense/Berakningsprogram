﻿using System.Security.Cryptography.X509Certificates;

namespace Berakningsprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till beräkningsprogrammet.");
            Console.WriteLine("Skriv 'hjälp' för hjälp!");
            string command;
            do
            {
                Console.Write("Kommando: ");
                command = Console.ReadLine();
                if (command == "plus")
                {
                    Console.Write("tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} + {Y} = {X + Y}");
                }
                else if (command == "gånger")
                {
                    Console.Write("tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} * {Y} = {X * Y}");
                }
                else if (command == "minus")
                {
                    Console.Write("Tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("Tal 2: ");
                    double Y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X} - {Y} = {X - Y}");
                }
                else if (command == "kvadrat")
                {
                    Console.Write("Tal 1: ");
                    double X = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{X}^2 = {X * X}");
                }
                else if (command == "hjälp")
                {
                    Console.WriteLine($"Tyvärr ej implementerat!");
                }
                else if (command == "sluta")
                {

                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
            Console.WriteLine("Hej då!");
        }
    }
}
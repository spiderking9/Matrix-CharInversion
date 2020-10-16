using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace AgileroKrakow
{
    class Test
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            #region Zadanie1Tests
            Console.WriteLine("Zadanie 1\n");
            Console.WriteLine(Zadanie1.CharInversion(null));
            Console.WriteLine(Zadanie1.CharInversion(""));
            Console.WriteLine(Zadanie1.CharInversion("  "));
            Console.WriteLine(Zadanie1.CharInversion("Alek"));
            Console.WriteLine(Zadanie1.CharInversion(" Al ek"));
            Console.WriteLine(Zadanie1.CharInversion("Wojtek"));
            Console.WriteLine(Zadanie1.CharInversion("Krzysiiiiiek"));
            Console.WriteLine(Zadanie1.CharInversion("wwwwXXXXXXXXX"));

            #region stopwatchZadanie1
            Stopwatch time1 = new Stopwatch();
            Stopwatch time2 = new Stopwatch();

            time1.Start();
            Regex rgx = new Regex("[^a-zA-Z']");
            rgx.Replace("Mare dssd///", "");
            time1.Stop();
            TimeSpan ts = time1.Elapsed;



            Console.WriteLine("Czas " + ts.TotalMilliseconds);
            time2.Start();
            Zadanie1.RemoveBadChars("Mare dssd///");
            time2.Stop();
            TimeSpan ts2 = time2.Elapsed;
            Console.WriteLine("Czas " + ts2.TotalMilliseconds);
            #endregion
            Console.WriteLine("----------------------------------");
            #endregion

            //Zadanie 2
            #region Zadanie2Tests
            Console.WriteLine("\nZadanie 2\n");
            Console.WriteLine("\n-Method1");
            #region Zad2Method1
            int[,] matrix = new int[,] {{ 0, 1, 2, 3, 4 , 4 , 4 , 5 },
                                        { 1, 1, 2, 3, 4 , 2 , 1 , 1 },
                                        { 2, 2, 2, 3, 4 , 3 , 2 , 1 },
                                        { 3, 3, 3, 3, 4 , 2 , 3 , 1 },
                                        { 4, 2, 4, 4, 4 , 2 , 3 , 4 },
                                        { 4, 4, 4, 4, 4 , 2 , 3 , 4 },
                                        { 4, 4, 4, 4, 4 , 3 , 3 , 4 },
                                        { 5, 4, 4, 4, 4 , 2 , 3 , 4 } };

            int[,] www = Zadanie2Method1.CountRectangle(matrix);
            Console.WriteLine($" Green : {www[0, 0]} Blue:   {www[0, 1]}\n " +
                              $"Orange: {www[1, 0]} Yellow: {www[1, 1]}");

            #endregion
            Console.WriteLine("\n-Method2");

            #region Zad2Method2
            Cell[,] rectangle = new Cell[,] {
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } },
                { new Cell { ValueOf = 3, Color = Color.Green }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 23, Color = Color.Blue }, new Cell { ValueOf = 123, Color = Color.Orange }, new Cell { ValueOf = 6, Color = Color.Yellow }, new Cell { ValueOf = 6, Color = Color.Blue }, new Cell { ValueOf = 6, Color = Color.Yellow } }
            };

            for (int i = 0; i < 2; i++) for (int j = 0; j < 2; j++) Console.Write($"{Zadanie2Method2.CountRectangle(rectangle)[i, j].Color}: {Zadanie2Method2.CountRectangle(rectangle)[i, j].ValueOf} ");
            
            #endregion
            #endregion

            Console.ReadKey();
        }
    }
}

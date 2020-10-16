using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AgileroKrakow
{
    public enum Color
    {
        Red, Green, Blue, Orange,Yellow
    }
    public class Cell 
    {
        public int ValueOf { get; set; }
        public Color Color { get; set; }
    }
    public class Zadanie2Method2
    {
        public static Cell[,] CountRectangle(Cell[,] bigRectangle)
        {
            //initialize Arrays Objects
            Cell[,] smalRectangle = new Cell[,] { { new Cell { ValueOf = 0, Color = Color.Green },new Cell { ValueOf = 0, Color = Color.Blue } }, { new Cell { ValueOf = 0, Color = Color.Orange }, new Cell { ValueOf = 0, Color = Color.Yellow } } };
            
            //iterate through matrix to count colors
            for (int i = 0; i < bigRectangle.GetLength(0); i++) for (int j = 0; j < bigRectangle.GetLength(1); j++)
                {
                    //segregate depend object color
                    switch (bigRectangle[i,j].Color)
                    {
                        case Color.Green:
                            smalRectangle[0, 0].ValueOf += bigRectangle[i, j].ValueOf;
                            break;
                        case Color.Blue:
                            smalRectangle[0, 1].ValueOf += bigRectangle[i, j].ValueOf;
                            break;
                        case Color.Orange:
                            smalRectangle[1, 0].ValueOf += bigRectangle[i, j].ValueOf;
                            break;
                        case Color.Yellow:
                            smalRectangle[1, 1].ValueOf += bigRectangle[i, j].ValueOf;
                            break;
                        default:
                            break;
                    }
                }
            return smalRectangle;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AgileroKrakow
{
    public class Zadanie2Method1
    {
        public static int[,] CountRectangle(int[,] bigRectangle)
        {
            //initialize var for length rows and columns
            int len1 = bigRectangle.GetLength(0);
            int len2 = bigRectangle.GetLength(1);

            //initialize small matrix 
            int[,] small = new int[2, 2];

            //iterate through matrix to count colors
            for (int i = 0; i < len1; i++)
                for (int j = 0; j < len2; j++)
                {
                    //segregate depend position in matrix
                    if      (j > i && i + 1 < len1 - j) small[0, 0] += bigRectangle[i,j];
                    else if (j > i && i + 1 > len1 - j) small[0, 1] += bigRectangle[i, j];
                    else if (j < i && i + 1 > len1 - j) small[1, 0] += bigRectangle[i, j];
                    else if (j < i && i + 1 < len1 - j) small[1, 1] += bigRectangle[i, j];
                }
            
            return small;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangles_within_a_square
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                buildFirstRow();
                buildSecondRow();
                buildThirdRow();
                buildFourthRow();
                buildFifthRow();
                buildSixRow();
                buildSeventhRow();
                buildEightRow();
                buildNinethRow();
                buildTenthRow();
            }
        }


        static void buildFirstRow()
        {
            int columns = 6;

            //First set of triangles....
            for (int i = 0; i < columns; i++)
            { 
                Console.Write("*");
                  
                for (int a = 0; a < 10; a++)
                {
                        Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildSecondRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 9; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildThirdRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 8; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildFourthRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 7; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildFifthRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 6; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildSixRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 5; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildSeventhRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 4; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildEightRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 3; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildNinethRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 2; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

        static void buildTenthRow()
        {
            int columns = 6;
            //First set of triangles....
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("*");
                }

                for (int a = 0; a < 1; a++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }

    }
}

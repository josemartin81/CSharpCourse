using System;

namespace CSharpCourse
{
    class Module2
    {


        static void Main(string[] args)
        {
            //number of columns & rows
            const int columns = 8;
            const int rows = 8;
            //char count
            int c = 0;
            //array with the board chars
            char[] board_chars = new char[2] { 'X', 'O' };
            int chars_len = board_chars.Length;

            //nested loop
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //using modulus operator to choose the appropiate char
                    Console.Write(board_chars[c % chars_len]);
                    c++;
                }
                Console.Write("\n");
                c++;
            }
            Console.ReadKey();
        }
    }
}
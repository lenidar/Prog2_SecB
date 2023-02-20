using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_SecB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loops vs Do-While loops
            #region While loops vs Do-While loops
            // a while loop is a loop that will loop until the given
            // condition is not anymore met
            int x = 0;

            while(x > 10)
            //while(x < 10)
            {
                Console.WriteLine("Hello there");
                x++;
            }
            Console.ReadKey();

            // how many times will the line "Hello there" be printed?
            // first condition is 0
            // second condition is 10

            x = 0;
            do
            {
                Console.WriteLine("Hello there");
                x++;
            } while (x > 10);
            Console.ReadKey();

            // the difference between a while and a do-while loop
            // is when the condition is evaluated. A while loop will 
            // evaluate the condition first before executing the code.
            // a do while loop will execute the code at least once. 

            #endregion
            // For loops vs Foreach loops
            #region For loops vs Foreach loops
            // similar to a while loop with additional variables.
            // it has 3 parts, initialization, condition and incrementation
            // the condition, while not required, is often related to the
            // variable being initialized and is liked with how the loop
            // will end.
            // You can say that a for loop is a more controlled version of
            // a while loop.
            int b = 5;
            int c = 20;

            for(int a = b; a < c; a++)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();

            // a foreach loop or statement is often used to display or 
            // iterate through a collection in ascending order. 
            int[] forLoopArray = new int[20];
            for (int a = 0; a < forLoopArray.Length; a++)
                Console.WriteLine(forLoopArray[a]);
            // - or -
            foreach(int element in forLoopArray)
                Console.WriteLine(element);

            #endregion
            // Topic for today
            #region Topic for today
            // arrays
            // collection of any single data type.
            // an array has fixed length/size.

            int[] arr1 = { };               // has undefined length
            int[] arr2 = new int[] { };     // has undefined length
            int[] arr3 = new int[5];        // has a defined length
            int[] arr4 = { 1, 2, 3, 4, 5 }; // content is defined

            // note : arrays with undefined lengths are often used as
            // placeholders and would be redefined in other parts of 
            // the code as necessary

            // arr1 has an undefined length.
            // What is its maximum index? undefined
            // what is the minimum index? undefined

            int[] arr5 = new int[1];
            // what is the length of arr5? 1
            // what is its maximum index? 0
            // what is the minimum index? 0

            // arr3 has a defined length 5. What is its maximum index? 4
            // what is the minimum index of arr3? 0

            // in summary. the length of an array is equivalent to how many
            // elements it can store within itself.
            // the indexes is the sequencial counting of the elements from 0
            // to the length - 1.

            arr1 = new int[20];
            // arr1 now has a length of? 20
            // arr1 element 18 has an index of? 17

            arr1[17] = 15;
            // this line means that you are assigning a value 15 to index 17
            // which is element 18

            // multi-dimensional arrays
            // jagged arrays
            // jagged arrays, simply put, are arrays within arrays....
            int[][] arr6 = new int[5][];
            arr6[0] = new int[2];
            arr6[1] = new int[3];
            arr6[2] = new int[4];
            arr6[3] = new int[5];
            arr6[4] = new int[6];
            // how many elements are int arr6? 20
            // what is the length of arr6? 5

            Console.WriteLine(arr6.Length); // 5
            Console.WriteLine(arr6[0].Length); // 2
            Console.WriteLine(arr6[1].Length); // 3
            Console.WriteLine(arr6[2].Length); // 4
            Console.WriteLine(arr6[3].Length); // 5
            Console.WriteLine(arr6[4].Length); // 6

            int[][][] arr7 = new int[6][][];
            for(int i = 0; i < arr7.Length; i++)
            {
                arr7[i] = new int[6][];
                for(int j = 0; j < arr7[i].Length; j++)
                {
                    arr7[i][j] = new int[6];
                }
            }
            // what is the length of arr7? 6
            // how many elements are int arr7? 216

            // multi-dimensional array (c#)
            int[,] arr8 = new int[5, 5];
            // a jagged array only needs 1 dimension in order to be 
            // declared
            // while a multi dimensional array needs all dimensions
            // defined

            // how many elements are in arr8? 25
            // what is the length of arr8? 25
            // what is the index of the 13th element? 2,2

            Console.WriteLine(arr8.Length); //25
            Console.WriteLine(arr8.GetLength(0)); //5
            Console.WriteLine(arr8.GetLength(1)); //5

            for(int i = 0; i < arr8.GetLength(0); i++)
            {
                for(int j = 0; j < arr8.GetLength(1); j++)
                {
                    arr8[i, j] = 0;
                }
            }


            int[][,] arr9 = { };
            int[,][] arr10 = { }; 

            #endregion
        }
    }
}

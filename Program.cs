using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassArrayAndPrintManagers
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager arrManager = new ArrayManager();
            PrintManager printManager = new PrintManager();
            int[,] arr = arrManager.CreateArr(5, 5);
            printManager.Print(arr);

            int max = arrManager.GetMax(arr);
            printManager.Print("max is", max);

            int[] arr2 = arrManager.GetDiagonalElements(arr);
            printManager.Print(arr2);


            Console.ReadKey();
        }

        public class ArrayManager
        {
            /// <summary>
            /// Creating two-dimensional array
            /// </summary>
            /// <param name="height">array size of Int32 type</param>
            /// <param name="weight">array size of Int32 type</param>
            /// <returns></returns>
            public int[,] CreateArr(int height, int width)
            {
                Random rnd = new Random();
                int[,] arr = new int[height, width];
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        arr[i, j] = rnd.Next(10, 99);
                    }
                }
                return arr;
            }
            /// <summary>
            /// Findes max element
            /// </summary>
            /// <param name="arr">given any two-dimensional array</param>
            /// <returns>Return max element of Int32 type</returns>
            public int GetMax(int[,] arr)
            {
                int max = arr[0, 0];
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    for (int j = 1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                return max;
            }
            /// <summary>
            /// Findes min element
            /// </summary>
            /// <param name="arr">given any two-dimensional array</param>
            /// <returns>Return min element of Int32 type</returns>
            public static int GetMin(int[,] arr)
            {
                int min = arr[0, 0];
                for (int i = 1; i < arr.GetLength(0); i++)
                {
                    for (int j = 1; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                        }
                    }
                }
                return min;
            }
            /// <summary>
            /// Findes indexes of the max element
            /// </summary>
            /// <param name="arr">given any two-dimensional array</param>
            /// <returns>returns indexes of max element</returns>
            public int GetMaxIndex(int[,] arr)
            {
                int maxIndexI = 0;
                int maxIndexJ = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > arr[maxIndexI, maxIndexJ])
                        {
                            maxIndexI = i;
                            maxIndexJ = j;
                        }
                    }
                }
                return maxIndexI; return maxIndexJ;
            }
            /// <summary>
            /// Findes indexes of the min element
            /// </summary>
            /// <param name="arr"> given any two-dimensional array</param>
            /// <returns>returns indexes of min element</returns>
            public int GetMinIndex(int[,] arr)
            {
                int minIndexI = 0;
                int minIndexJ = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > arr[minIndexI, minIndexJ])
                        {
                            minIndexI = i;
                            minIndexJ = j;
                        }
                    }
                }
                return minIndexI; return minIndexJ;
            }
            /// <summary>
            /// Finds diagonal elements of two-dimensional array
            /// </summary>
            /// <param name="arr">given any two-dimensional array</param>
            /// <returns>return one-dimensional array</returns>
            public int[] GetDiagonalElements(int[,] arr)
            {
                int[] diagonal = new int[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    diagonal[i] = arr[i, i];
                }
            
                return diagonal;
            }
        /// <summary>
        /// Finds the max element of one-dimensional array
        /// </summary>
        /// <param name="arr">given any one-dimensional array</param>
        /// <returns>return max element of Int32 type</returns>
        public int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        /// <summary>
        /// Finds the min element of one-dimensional array
        /// </summary>
        /// <param name="arr">given any one-dimensional array</param>
        /// <returns>return min element of Int32 type</returns>
        public int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        /// <summary>
        /// Finds index of the max element of the one-dimensional array
        /// </summary>
        /// <param name="arr">given any one-dimensional array</param>
        /// <returns>return index of the max element</returns>
        public int GetMaxIndex(int[] arr)
        {
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        /// <summary>
        /// Finds index of the min element of the one-dimensional array
        /// </summary>
        /// <param name="arr">given any one-dimensional array</param>
        /// <returns>return index of the min element</returns>
        public int GetMinIndex(int[] arr)
        {
            int minIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

    }
    public class PrintManager
    {
        /// <summary>
        /// Prints two-dimensional array elements
        /// </summary>
        /// <param name="arr">given any two-dimensional array</param>
        public void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine(); ;
            }
        }
        /// <summary>
        /// Prints one-dimensional array elements
        /// </summary>
        /// <param name="arr">given any one-dimensional array</param>
        /// <returns></returns>
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
        }
        public void Print(string name, int value)
        {
            Console.WriteLine($"{name} = {value}");
        }
        /// <summary>
        /// Prints indexes of two-dimensional array
        /// </summary>
        /// <param name="name">given any two-dimensional array</param>
        /// <param name="value">index1</param>
        /// <param name="value2">index2</param>
        public void Print(string name, int value, int value2)
        {
            Console.WriteLine($"{name} = {value}&{value2}");
        }
    }
}
}

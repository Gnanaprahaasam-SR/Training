using System;

namespace ArrayFunction1
{
    class Array{
        public static void Main(string[] args)
        {
            // int row,column;
            // Console.Write("\nEnter the No.of row:");
            // row = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\nEnter the No.of column:");
            // column = Convert.ToInt32(Console.ReadLine());
            // int[,] array = new int[row,column];
            // Console.Write("\nEnter the Input element:");
            // for(int first = 0; first < row; first++)
            // {
            //     for(int second = 0; second < column; second++)
            //     {
            //         Console.Write("Element of {0}{1} index is:",first,second);
            //         array[first,second]=Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // for(int first = 0; first < row; first++)
            // {
            //     for(int second = 0; second < column; second++)
            //     {
            //         Console.Write(array[first,second]+"\t");
            //     }
            //     Console.Write("\n");
            // }


            // int row1,column1,row2,column2;
            // Console.Write("\nEnter the First Matrix row count :");
            // row1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\nEnter the First matrix column count:");
            // column1 = Convert.ToInt32(Console.ReadLine());
            // int[,] array1 = new int[row1,column1];
            // Console.Write("\nEnter the Input element:");
            // for(int first = 0; first < row1; first++)
            // {
            //     for(int second = 0; second < column1; second++)
            //     {
            //         Console.Write("\nElement of {0}{1} index is:",first,second);
            //         array1[first,second]=Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // Console.Write("\nEnter the Second Matrix row count :");
            // row2 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\nEnter the Second matrix column count:");
            // column2 = Convert.ToInt32(Console.ReadLine());
            // int[,] array2 = new int[row2,column2];
            // Console.Write("\nEnter the Input element:");
            // for(int first = 0; first < row2; first++)
            // {
            //     for(int second = 0; second < column2; second++)
            //     {
            //         Console.Write("\nElement of {0}{1} index is:",first,second);
            //         array2[first,second]=Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            //Console.WriteLine("\nAddition of two matrix:");
            // int[,] array3 = new int [row1,column2];
            // for(int first = 0; first < row1 ; first++)
            // {
            //     for(int second = 0; second < column2; second++)
            //     {
            //         array3[first,second] = array1[first,second]+array2[second,first];
            //         Console.Write(array3[first,second]+"\t");
            //     }
            //     Console.Write("\n");
            // }

     
            // int row1,column1,row2,column2;
            // Console.Write("\nEnter the First Matrix row count :");
            // row1 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\nEnter the First matrix column count:");
            // column1 = Convert.ToInt32(Console.ReadLine());
            // int[,] array1 = new int[row1,column1];
            // Console.Write("\nEnter the Input element:");
            // for(int first = 0; first < row1; first++)
            // {
            //     for(int second = 0; second < column1; second++)
            //     {
            //         Console.Write("\nElement of {0}{1} index is:",first,second);
            //         array1[first,second]=Convert.ToInt32(Console.ReadLine());
            //     }
            // }

            // Console.Write("\nEnter the Second Matrix row count :");
            // row2 = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\nEnter the Second matrix column count:");
            // column2 = Convert.ToInt32(Console.ReadLine());
            // int[,] array2 = new int[row2,column2];
            // Console.Write("\nEnter the Input element:");
            // for(int first = 0; first < row2; first++)
            // {
            //     for(int second = 0; second < column2; second++)
            //     {
            //         Console.Write("\nElement of {0}{1} index is:",first,second);
            //         array2[first,second]=Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            // Console.WriteLine("\nSubtraction of two matrix:");
            // int[,] array3 = new int [row1,column2];
            // for(int first = 0; first < row1 ; first++)
            // {
            //     for(int second = 0; second < column2; second++)
            //     {
            //         array3[first,second] = array1[first,second]-array2[second,first];
            //         Console.Write(array3[first,second]+"\t");
            //     }
            //     Console.Write("\n");
            // }



                int row1,column1,row2,column2;
            Console.Write("\nEnter the First Matrix row count :");
            row1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the First matrix column count:");
            column1 = Convert.ToInt32(Console.ReadLine());
            int[,] array1 = new int[row1,column1];
            Console.Write("\nEnter the Input element:");
            for(int first = 0; first < row1; first++)
            {
                for(int second = 0; second < column1; second++)
                {
                    Console.Write("\nElement of {0}{1} index is:",first,second);
                    array1[first,second]=Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nEnter the Second Matrix row count :");
            row2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Second matrix column count:");
            column2 = Convert.ToInt32(Console.ReadLine());
            int[,] array2 = new int[row2,column2];
            Console.Write("\nEnter the Input element:");
            for(int first = 0; first < row2; first++)
            {
                for(int second = 0; second < column2; second++)
                {
                    Console.Write("\nElement of {0}{1} index is:",first,second);
                    array2[first,second]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nMultiplication of two matrix:");
            int[,] array3 = new int [row1,column2];
            for(int first = 0; first < row1 ; first++)
            {
                for(int second = 0; second < column2; second++)
                {
                    array3[first,second] = array1[first,second]*array2[second,first];
                    Console.Write(array3[first,second]+"\t");
                }
                Console.Write("\n");
            }
        }
    }
}

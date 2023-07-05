namespace loop
{
    class Loop
    {
        public static void Main(string[]args)
        {
            // int initialValue = 1;
            // Console.WriteLine("\nDisplay the first 10 Natural Numbers:");
            // Console.Write("\n----------------------------");
            // Console.WriteLine("\nThe First 10 Natural Numbers are..");
            // for(int initial = initialValue; initial <= 10; initial++)
            // {
            //     Console.Write("\n"+initial);
            // }

            // int initialValue = 1,sum = 0;
            // Console.WriteLine("\nFind the sum of first 10 Natural Numbers:");
            // Console.Write("\n----------------------------");
            
            // for(int initial = initialValue; initial <= 10; initial++)
            // {
            //     sum += initial;
            //     Console.WriteLine("\nThe sum of {0}th Natural Numbers is {1}.",initial,sum);
            // }

            // int initial = 1, number, sum = 0;
            // Console.WriteLine("Display n terms of natural number and their sum:");
            // Console.Write("\n---------------------");
            // Console.WriteLine("\nEnter the terms value:");
            // number = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("\nthe First {0} Natural number is:",number);
            // for(int value = initial ;value <= number; value++)
            // {
            //     Console.WriteLine("{0}",value);
            //     sum += value;
            //     if(value == number)
            //     {
            //         Console.WriteLine("\nthe sum of the Natural number upto {0} is {1}",number,sum);
            //     }
            // }

            // int initial = 1, number, sum = 0, average;
            // Console.WriteLine("How many even number you want:");
            // number = Convert.ToInt32(Console.ReadLine());
            // Console.Write("\n---------------------\n");
            // for(int value = initial ;value <= number; value++)
            // {
            //     Console.WriteLine("Number {0} is {1}",value,value*2);
            //     sum += value*2;
            //     average = sum/value;
            //     if(value == number)
            //     {
            //         Console.WriteLine("\nThe sum of the Even number upto {0} is {1}",number,sum);
            //         Console.WriteLine("\nAverage is :{0}",average);
            //     }
            // }     

            // int initial = 1,Number,cube;
            // Console.WriteLine("Enter the number of term:");
            // Number = Convert.ToInt32(Console.ReadLine());
            // while(true)
            // {
            //     cube = initial*initial*initial;
            //     Console.WriteLine("Number is:{0} and cube of the {1} is: {2}",initial,initial,cube);
            //     initial++;
            //     if(initial > Number)
            //     {
            //        break;
            //     }
            // }

            // int initial = 1,Number,value;
            // Console.WriteLine("Enter the number (Table to be calculated):");
            // Number = Convert.ToInt32(Console.ReadLine());
            // while(true)
            // {
            //     value = initial*Number;
            //     Console.WriteLine("{0} * {1} = {2}",initial,Number,value);
            //     initial++;
            //     if(initial > 10)
            //     {
            //        break;
            //     }
            // }


            // int Number;
            // Console.WriteLine("Enter the number of term:");
            // Number = Convert.ToInt32(Console.ReadLine());
            // for(int initial = 1 ; initial <= Number; initial++)
            // { 
            //     for(int value = 1 ; value <= 10 ; value++)
            //     {
            //         Console.WriteLine("{0} * {1} = {2}",value,initial,value*initial);
            //     }
            // }

            // int xAxis, yAxis, rows;
            // Console.WriteLine("\nDisplay the pattern like right angle using asterisk:");
            // Console.Write("\n-------------------");
            // Console.WriteLine("\nEnter the rows:");
            // rows = Convert.ToInt32(Console.ReadLine());
            // for( xAxis = 1; xAxis <= rows ; xAxis++)
            // {
            //     for(yAxis = 1 ;yAxis <= xAxis ; yAxis++)
            //     {
            //         Console.Write("*");
            //     }
            //     Console.Write("\n");
            // }

            int xAxis, yAxis, rows;
            Console.WriteLine("\nDisplay the pattern as like right angle using number:");
            Console.Write("\n-------------------");
            Console.WriteLine("\nEnter the rows:");
            rows = Convert.ToInt32(Console.ReadLine());
            for( xAxis = 1; xAxis <= rows ; xAxis++)
            {
                for(yAxis = 1 ;yAxis <= xAxis ; yAxis++)
                {
                    Console.Write(yAxis);
                }
                Console.Write("\n");
            }

        }
    }
}

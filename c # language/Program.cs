namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter your Name:");
            // string name=Console.ReadLine();
            // Console.WriteLine("Enter your Age:");
            // int age =Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Hi, I am "+name+" "+age+" old male person working Tnxt");


            // int first,second;
            // Console.WriteLine("Check whether two integers are equal or not:\n");
            // Console.Write("--------------------------");
            // Console.WriteLine("\nEnter first numbers");
            // first = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter Second Number:");
            // second = Convert.ToInt32(Console.ReadLine());

            // if(first == second)
            // {
            //     Console.WriteLine("{0} and {1} are equal \n",first,second);
            // }
            // else 
            // {
            //     Console.WriteLine("{0} and {1} are Notequal \n",first,second);
            // }

            // int value;
            // Console.Write("---------------------------\n");
            // Console.WriteLine("Check whether the number is even or odd:");
            // value = Convert.ToInt32(Console.ReadLine());
            // if(value%2==0)
            // {
            //     Console.WriteLine("Given {0} is Even",value);
            // }
            // else{
            //     Console.WriteLine("Given {0} is Odd",value);
            // }

            // int value1;
            // Console.Write("---------------------------\n");
            // Console.WriteLine("Check whether the number is positive or Negative:");
            // value1 = Convert.ToInt32(Console.ReadLine());
            // if(value1<0)
            // {
            //     Console.WriteLine("Given {0} is Negative",value1);
            // }
            // else{
            //     Console.WriteLine("Given {0} is Positive",value1);
            // }

            // int year;
            // Console.WriteLine("Check whether a given year is leap year or not\n");
            // Console.Write("-----------------------\n");
            // Console.WriteLine("Enter a Year: ");
            // year = Convert.ToInt32(Console.ReadLine());
            // if(year % 400 == 0 )
            // {
            //     Console.WriteLine("{0} is a leap year\n",year);
            // }
            // else{
            //     if(year % 100 == 0)
            //     {
            //         Console.WriteLine("{0} is Not a leap year\n",year);
            //     }
            //     else{
            //         if(year % 4 == 0)
            //         {
            //             Console.WriteLine("{0} is a leap year\n",year);
            //         }
            //         else{
            //             Console.WriteLine("{0} is Not a leap year\n",year);
            //         }
            //     }
            // }

            // int m_value,n_value;
            // Console.WriteLine("display the value of n is 1,0 and -1 for m:\n");
            // Console.Write("-----------------------\n");
            // Console.WriteLine("Enter the value of m:");
            // m_value = Convert.ToInt32(Console.ReadLine());
            // if(m_value != 0)
            // {
            //     if(m_value > 0)
            //     {
            //         n_value = 1;
            //     }
            //     else
            //     {
            //         n_value = -1;
            //     }
            // }
            // else{
            //     n_value = 0;
                
            // }
            // Console.WriteLine("the value of m ={0}\n",m_value);
            // Console.WriteLine("the value of n = {0}\n",n_value);

            
            // float height;
            // Console.WriteLine("Accept the height of a person in centimeter and categorize them:\n");
            // Console.WriteLine("----------------");
            // Console.WriteLine("\nEnter the height of the person (in centimetres):");
            // height = Convert.ToInt32(Console.ReadLine());
            // if(height < 150.0)
            // {
            //     Console.WriteLine("the Person is Dwarf\n");
            // }
            // else if(height >= 150.0 && height <= 165.0)
            // {
            //     Console.WriteLine("the person  is average heighted. \n");
            // }
            // else if(height >= 165.0 && height <= 195.0)
            // {
            //     Console.WriteLine("The person is taller.\n");
            // }
            // else{
            //     Console.WriteLine("Abnormal height.\n");
            // }

            // int number1, number2, number3;
            // Console.WriteLine("Find the largest number Three number:");
            // Console.Write("------------------------\n");
            // Console.WriteLine("Enter the first Number:");
            // number1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("\nEnter second Number: ");
            // number2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("\nEnter third Number :");
            // number3 = Convert.ToInt32(Console.ReadLine());
            // if (number1 > number2 && number1>number3) {
            //     Console.WriteLine("The first number is greatest among three ");
            // }
            // else if(number2 > number1 && number2 > number3)
            // {
            //     Console.WriteLine("The Second number is greatest among three");
            // }
            // else{
            //     Console.WriteLine("The Third number is greatest among three");
            // }

            // int infinite1, infinite2;
            // Console.WriteLine("Find the quadrant in which the coordinate point lies:\n");
            // Console.Write("--------------------------\n");
            // Console.WriteLine("Enter x-coordinate: ");
            // infinite1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("\nEnter y-coordinate: ");
            // infinite2 = Convert.ToInt32(Console.ReadLine());
            // if(infinite1 > 0 && infinite2 > 0 )
            // {
            //     Console.WriteLine("\nThe coordinate points {0}and {1} lies in first quadrant:",infinite1,infinite2);
            // }
            // else if(infinite1 < 0 && infinite2 > 0)
            // {
            //     Console.WriteLine("\nThe coordinate points {0} and {1} lies in second quadrant:",infinite1,infinite2);
            // }
            // else if(infinite1 < 0 && infinite2 < 0)
            // {
            //     Console.WriteLine("\nThe coordinate points {0} and {1} lies in Third quadrant:",infinite1,infinite2);
            // }
            // else if(infinite1 > 0 && infinite2 < 0)
            // {
            //     Console.WriteLine("\nThe coordinate points {0}and {1} lies in fourth quadrant:",infinite1,infinite2);
            // }
            // else if(infinite1 == 0 && infinite2 ==0)
            // {
            //     Console.WriteLine("\nThe coordinate points {0}and {1} lies at origin:",infinite1,infinite2);
            // }


            int physics, chemistry, Maths;
            Console.WriteLine("Find the eligibility for admission:\n ");
            Console.Write("---------------------");
            Console.WriteLine("\n Eligibility criteria:");
            Console.WriteLine("\n Marks in Maths >= 65\nMarks in Physics >= 55 \n Marks in Chemistry >= 50\n Total in all the three subject >= 180\nTotal in Maths and Physics >= 140");
            Console.Write("\n---------------------------------------");
            Console.WriteLine("\nEnter the marks obtained in Physics:");
            physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter the marks Obtained in Chemsitry:");
            chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter marks obtained in Maths:");
            Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTotal marks of Maths,Physics and chemistry:{0}",Maths+physics+chemistry);
            Console.WriteLine("\nTotal marks of Maths and Physics:{0}",Maths+physics);
            if(Maths >= 65 && physics >= 55 && chemistry >= 50)
            {
                if((Maths+physics+chemistry) >= 180 || (Maths+physics) >= 140)
                {
                    Console.WriteLine("\nThe candidate is Eligible for Admission");
                }
                else{
                    Console.WriteLine("\nThe candidate is Not-eligible for Admission");
                }
            }
            else
            {
                Console.WriteLine("\nThe candidate is Not-eligible for Admission");
            }
            
        }
    }
}
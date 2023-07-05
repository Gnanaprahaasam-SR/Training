using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace ArrayFunction
{
    class Array{
        public static void Main(string[] args)
        {
            // int[] arrayValue = new int[10];
            // Console.WriteLine("Read and print element of an array:");
            // Console.Write("\n---------------------");
            // Console.WriteLine("\nInput 10 elements in array:");
                        
            // for(int value = 0 ;value < 10; value++)
            // {
            //     Console.Write("\nElement - {0} :",value);               
            //     arrayValue[value]=Convert.ToInt32(Console.ReadLine());
            // }
            // Console.Write("\nThe Elements in array are:");
            // foreach(int value in arrayValue)
            // {
            //    Console.Write("{0} ",value);
            // }
            
            // int sizeOfArray;
            // Console.Write("Enter the Size Of Array:");
            // sizeOfArray = Convert.ToInt32(Console.ReadLine());
            // int[] arrayValue = new int[sizeOfArray];
            // Console.Write("Input {0} number of element of array:",sizeOfArray);
            // for(int intial = 0; intial < sizeOfArray; intial++)
            // {
            //     Console.Write("\nElement-{0}: ",intial) ;
            //     arrayValue[intial] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.Write("\nthe values are stored in array:");
            // foreach (int values in arrayValue)
            // {
            //     Console.Write("{0} ",values);
            // }
            
            // Console.Write("\nArray in reverse order:");
            // for(int intial = sizeOfArray-1 ; intial >= 0;intial--)
            // {
            //     Console.Write("{0} ",arrayValue[intial]);
            // }

            // sum of array value

            // int sizeOfArray,sum = 0;
            // Console.Write("Enter the Size Of Array:");
            // sizeOfArray = Convert.ToInt32(Console.ReadLine());
            // int[] arrayValue = new int[sizeOfArray];
            // Console.Write("Input {0} number of element of array:",sizeOfArray);
            // for(int intial = 0; intial < sizeOfArray; intial++)
            // {
            //     Console.Write("\nElement-{0}: ",intial) ;
            //     arrayValue[intial] = Convert.ToInt32(Console.ReadLine());
            //     sum +=arrayValue[intial];
            // }
            // Console.WriteLine("Sum of All element sorted in Array is "+sum);

            // Copy of array
            // int sizeOfArray;
            // Console.Write("Enter the Size Of Array:");
            // sizeOfArray = Convert.ToInt32(Console.ReadLine());
            // int[] arrayValue = new int[sizeOfArray];
            // Console.Write("Input {0} number of element of array:",sizeOfArray);
            // for(int intial = 0; intial < sizeOfArray; intial++)
            // {
            //     Console.Write("\nElement-{0}: ",intial) ;
            //     arrayValue[intial] = Convert.ToInt32(Console.ReadLine());
            // }
            // foreach (int values in arrayValue)
            // {
            //     Console.Write("{0} ",values);
            // }
            // int[] dummy = arrayValue;
            // Console.Write("\nDublicate of Array:")
            // foreach (int values in dummy)
            // {
            //     Console.Write("{0} ",values);                                         
            // }

            //Duplicate element in array

            // int sizeOfArray, count=0;
            // Console.Write("Enter the Size Of Array:");
            // sizeOfArray = Convert.ToInt32(Console.ReadLine());
            // int[] arrayValue = new int[sizeOfArray];
            
            // Console.Write("Input {0} number of element of array:",sizeOfArray);
            // for(int intial = 0; intial < sizeOfArray; intial++)
            // {
            //     Console.Write("\nElement-{0}: ",intial) ;
            //     arrayValue[intial] = Convert.ToInt32(Console.ReadLine());
            // }
            // Console.Write("\n No. of Duplicate elements:");
            // for(int intial = 0 ; intial < sizeOfArray; intial++)
            // {
            //     for(int second = intial+1 ; second < sizeOfArray; second++ )
            //     {
            //         if(arrayValue[intial] == arrayValue[second])
            //         {
            //             count++;
            //         }
            //     }
                
            // }
            // Console.Write("Total no.of dupplicate value count in Array:"+count);

            // int sizeOfArray;
            // Console.Write("\n Print the unquie elements of array:");
            // Console.Write("\n-----------------");
            // Console.Write("\nEnter the Size Of Array:");
            // sizeOfArray = Convert.ToInt32(Console.ReadLine());
            // int[] arrayValue = new int[sizeOfArray];            
            // Console.Write("Input {0} number of element of array:",sizeOfArray);
            // for(int intial = 0; intial < sizeOfArray; intial++)
            // {
            //     Console.Write("\nElement-{0}: ",intial) ;
            //     arrayValue[intial] = Convert.ToInt32(Console.ReadLine());
            // }
           
            // for(int intial = 0 ; intial < sizeOfArray; intial++)
            // {
            //     for(int second = intial+1 ; second < sizeOfArray; second++ )
            //     {
            //         if(arrayValue[intial] == arrayValue[second])
            //         {
            //              continue;
            //         }
            //         else{
            //                 Console.Write("\nUnique Elements are "+arrayValue[intial]);
            //         }
            //     }
            // }   

            //     int sizeOfArray;
            //     Console.Write("\nMerge the two array and show in ascending order");
            //     Console.Write("\n------------");
            //     Console.Write("\nEnter the Size Of Array:");
            //     sizeOfArray = Convert.ToInt32(Console.ReadLine());          

            //     int[] array1 = new int[sizeOfArray];
            //     int[] array2 = new int[sizeOfArray];
            //     int[] array3 = new int[sizeOfArray*2];
            //     Console.Write("\nEnter the First array value:");
            //     Console.Write("\nInput {0} number of element of array:",sizeOfArray);
            //     for(int intial = 0; intial < sizeOfArray; intial++)
            //     {
            //         Console.Write("\nElement-{0}: ",intial) ;
            //         array1[intial] = Convert.ToInt32(Console.ReadLine());
            //     }
            //     Console.Write("\nEnter the First array value:");
            //     for(int intial = 0; intial < sizeOfArray; intial++)
            //     {
            //         Console.Write("\nElement-{0}: ",intial) ;
            //         array2[intial] = Convert.ToInt32(Console.ReadLine());
            //     }
                
            //     for(int intial = 0; intial < (sizeOfArray*2); intial++)
            //     {
            //         if( intial < sizeOfArray)
            //         {
            //             array3[intial] = array1[intial];
            //         }
            //         else 
            //         {
            //             array3[intial] = array2[intial-sizeOfArray];
            //         }
            //     }
                
            //     for(int first = 0 ;first < (sizeOfArray*2)-1 ; first++)
            //     {
            //         for(int second = first+1 ; second < (sizeOfArray*2); second++)
            //         {
            //             if(array3[first] > array3[second])
            //             {
            //                 int temp;
            //                 temp = array3[first];
            //                 array3[first] = array3 [second];
            //                 array3[second]= temp;                        
            //             }
                        
            //         }
            //     }
            //    foreach(int intial in array3)
            //    {
            //     Console.Write(intial);
            //    }
                

            // int ArraySize;            
            // Console.Write("\nFind the Frequency of element in an array:");
            // Console.Write("\n------------------------");
            // Console.Write("\nEnter the Size of Array:");
            // ArraySize = Convert.ToInt32(Console.ReadLine());
            // int[] array1= new int[ArraySize];
            // Console.Write("\nEnter the Array-Element:");
            // for(int intial = 0 ; intial < ArraySize; intial++)
            // {
            //     Console.Write("\nElement of {0} index is:",intial);
            //     array1[intial] = Convert.ToInt32(Console.ReadLine());

            // }
            // int count=0;
            // int[] array2 = new int[ArraySize];
            // for(int first = 0; first < ArraySize; first++)
            // {
            //     for(int second = 0; second < ArraySize; second++)
            //     {
            //         if(array1[first] == array1[second])
            //         {
            //             count++;
            //         }
            //     }
            //     array2[first]=count;
            //     count=0;
            // }
            // foreach(int intial in array2)
            // {
            //     Console.Write(intial);
            // }

            // int ArraySize;            
            // Console.Write("\nFind the Minimum and maximum of element in an array:");
            // Console.Write("\n------------------------");
            // Console.Write("\nEnter the Size of Array:");
            // ArraySize = Convert.ToInt32(Console.ReadLine());
            // int[] array1= new int[ArraySize];
            // Console.Write("\nEnter the Array-Element:");
            // for(int intial = 0 ; intial < ArraySize; intial++)
            // {
            //     Console.Write("\nElement of {0} index is:",intial);
            //     array1[intial] = Convert.ToInt32(Console.ReadLine());

            // }
            // for(int first = 0 ;first < (ArraySize-1) ; first++)
            // {
            //     for(int second = first+1 ; second < ArraySize; second++)
            //     {
            //         if(array1[first] > array1[second])
            //         {
            //             int temp;
            //             temp = array1[first];
            //             array1[first] = array1 [second];
            //             array1[second]= temp;                        
            //         }
                    
            //     }
            // }

            // int ArraySize;            
            // Console.Write("\nFind the Odd and Even number in an array:");
            // Console.Write("\n------------------------");
            // Console.Write("\nEnter the Size of Array:");
            // ArraySize = Convert.ToInt32(Console.ReadLine());
            // int[] array1= new int[ArraySize];
            // int[] OddArray = new int[ArraySize];
            // int[] EvenArray = new int[ArraySize];
            // Console.Write("\nEnter the Array-Element:");
            // for(int intial = 0 ; intial < ArraySize; intial++)
            // {
            //     Console.Write("\nElement of {0} index is:",intial);
            //     array1[intial] = Convert.ToInt32(Console.ReadLine());

            // }
            // int index = 0;
            // int index1 = 0;
            // for (int intial = 0; intial < ArraySize ; intial++)
            // {                
            //     if(array1[intial] % 2 == 0)
            //     {
            //         EvenArray[index] =array1[intial];
            //         index++;
            //     }
            //     else{
                   
            //         OddArray[index1] =array1[intial];
            //         index1++;
            //     }
            // }
            // foreach(int intial in EvenArray)
            // {
            //     Console.Write("Event Elements are:"+intial);
            // }
            //   foreach(int intial in OddArray)
            // {
            //     Console.Write("Odd Elements are:"+intial);
            // }

            
        }
    }
}
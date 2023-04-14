using System;
using System.ComponentModel;

namespace IterationStatements
{
	public class Triangle
	{
		
             public static void Multiplication(int digit)
            {
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine(i * digit);
                }

                public static void Print1000()
                {
                    for (int i = 1000; i >= -1000; i--) 
                    Console.WriteLine(i);

                }

                 public static void ThreeUp()

                {
                    for (int i = 3; i <= 999; i += 3) 
                    {
                        Console.WriteLine(i);
                    }

                }
                

                public  static bool AreTheyTheSame(int x, int y)
                {
                    if (x != y)
                    {
                        return (false);
                    }
                    else
                    {
                        return (true);     
                    }

                    public static void IsItOdd(int x)
                    {
                     if (x % 2 == 0) ;
                        {
                            Console.WriteLine("thats even!");

                        }
                        
                        {
                          Console.WriteLine("thats odd");


                        }
                        public static bool IsPositive(int x)
                        {
                            if (x > 0)
                            {
                                return (true);
                            }
                            return (false);


                        }
                        public static bool Range(int x)
                        {
                            if (x <=10 && x >= -10)

                            {
                                return (true);
                            }
                            return (false);


                        }

                        public static void CanVote()
                        {

                            Console.WriteLine("How old are you?");
                            int age = int.Parse(Console.ReadLine());
                            if (age <=18)
                            {
                                Console.WriteLine("You are old enough to vote");
                            }
                            else
                            {
                                Console.WriteLine("You can't vote");
                            }
                               

                        }


                    }
                    
                       

                    






                }






                




            }

        
        

       
        
    }
}











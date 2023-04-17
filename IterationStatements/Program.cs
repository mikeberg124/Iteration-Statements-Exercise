namespace IterationStatements
{
    public class Program



    {


        static void Main(string[] args)
        {




            Triangle.Print1000();

            

            AreTheyTheSame(7, 8);

            IsItOdd(7);

            Triangle.IsPositive(8);

            Triangle.Range(10);

            Triangle.Multiplication(7);

            Triangle.CanVote();








        }
        public static bool AreTheyTheSame(int x, int y)
        {
            if (x != y)
            {
                return (false);
            }
            else
            {
                return (true);
            }





        }

        public static void IsItOdd(int x)
        {
            if (x % 2 == 0) 
            {
                Console.WriteLine("thats even!");

            }

            {
                Console.WriteLine("thats odd");


            }
            





        }
    }
}
           
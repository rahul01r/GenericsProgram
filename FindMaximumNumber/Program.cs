namespace FindMaximumNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Maximum Number Problems Statement");
            while (true)
            {
                Console.WriteLine("Select program \n1.Find The Greatest Number Among Three Integer Value");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int Output = MaximumNumberCheck.FindMaxIntNumber(12, 11, 18);
                        Console.WriteLine("Greatest No. is:"+Output);
                        break;

                }
            }
        }
    }
}
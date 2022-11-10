namespace FindMaximumNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Text Maximum Number Problems Statement");
            while (true)
            {
                Console.WriteLine("Select program \n1.Find The Greatest Number Among Three Integer Value\n2.Find The Greatest Number Among Three Float Value\n3.Find The Greatest Number Among Three String Value");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int Output = MaximumNumberCheck.FindMaxIntNumber(12, 11, 18);
                        Console.WriteLine("Greatest No. is:"+Output);
                        break;
                    case 2:
                        double Output1 = MaximumNumberCheck.FindMaxDoubleNumber(12.5, 18.9, 5.5);
                        Console.WriteLine("Greatest No. is:"+Output1);
                        break;
                    case 3:
                        string Output2 = MaximumNumberCheck.FindMaxStringNumber("abc", "MNO", "AbC");
                        Console.WriteLine("Greatest No. is:"+Output2);
                        break;
                }
            }
        }
    }
}
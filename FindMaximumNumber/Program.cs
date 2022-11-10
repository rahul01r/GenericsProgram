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
                        Console.WriteLine("Enter the First number: ");
                        int first = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the second number: ");
                        int second = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the third number: ");
                        int third = Convert.ToInt32(Console.ReadLine());

                       MaximumNumberCheck<int> maxnumObj = new MaximumNumberCheck<int>(first, second, third);
                        int maxNumber = maxnumObj.GetMaxNum();

                        Console.WriteLine("your max number {0}", maxNumber);
                        break;
                    case 2:
                        Console.WriteLine("Enter the First number: ");
                        float firstf = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter the second number: ");
                        float secondf = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine("Enter the third number: ");
                        float thirdf = Convert.ToSingle(Console.ReadLine());

                        MaximumNumberCheck<float> maxnumObj1 = new MaximumNumberCheck<float>(firstf, secondf, thirdf);
                        var maxNumber1 = maxnumObj1.GetMaxNum();

                        Console.WriteLine("your max float number {0}", maxNumber1);
                        break ;
                    case 3:
                        Console.WriteLine("Enter the First string: ");
                        string firsts = Console.ReadLine();

                        Console.WriteLine("Enter the second string: ");
                        string seconds = Console.ReadLine();

                        Console.WriteLine("Enter the third string: ");
                        string thirds = Console.ReadLine();

                        MaximumNumberCheck<string> maxnumObj2 = new MaximumNumberCheck<string>(firsts, seconds, thirds);
                        string last = maxnumObj2.GetMaxNum();

                        Console.WriteLine("The last string in the sort order by comparedTo method is : {0}", last);
                        break ;
                }
            }
        }
    }
}
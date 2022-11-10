namespace FindMaximumNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericsMaximum<int> genericsMaximum = new GenericsMaximum<int>(intArray);
            genericsMaximum.PrintMaxValue();
            double[] doubleArray = { 11.2, 32.5, 4.32, 55.5, 6.78 };
            GenericsMaximum<double> genericdouble = new GenericsMaximum<double>(doubleArray);
            genericdouble.PrintMaxValue();
            string[] stringArray = { "ABC", "xyz", "def", "MNO", "axz" };
            GenericsMaximum<string> genericstring = new GenericsMaximum<string>(stringArray);
            genericstring.PrintMaxValue();

        }
    }
        
    
}
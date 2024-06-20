using System;


/// Attributes of a Function
/// 1. <Access Specifier>
/// 2. <Return Type>
/// 3. <Method name>(Parameter)
/// 4. {<Body>}

// Access Specifier determines whether the function can be called from another class

// public: This function can be accessed from another class
// Private: This type of function can't be accessed from another class
// protected: This function can't be accessed by class and derived classes


namespace ConsoleApp1
{
    public class Program
    {


        static void Main(string[] args)
        {
            double x = 7;
            double y = 4;
            Console.WriteLine($"{x} * {y} = {getSum(x, y)}");

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine($"Before Swap num1: {num3},  num2: {num4}");
            Swap(ref num3, ref num4);
            Console.WriteLine($"After Swap num1: {num3},  num2: {num4}");
            Console.WriteLine("2+ 8 + 10 + 54 + 18 + 51 = {0}", GetSomeMore(2, 8, 10, 54, 18, 51));
        }




        static double getSum(double x, double y)
        {
            return x + y;
        }

        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        ///Passing array as the parameter of a function
        static double GetSomeMore(params double[] nums)
        {
            double sum = 0;
            foreach (double num in nums)
            {
                sum += num;
            }
            return sum;
        }



    }


}

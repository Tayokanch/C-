// See https://aka.ms/new-console-template for more information

/// C# Methods
Random dice = new Random();
int roll = dice.Next(0, 3);
String[] names = new String[] { "tayo", "Teni", "Eazy", "Tope" };

Console.WriteLine(names[roll]);

int[] values = new int[] { 600, 700, 1200, 500, 100, 430, 800 };
int maxValue = values[0];
for (int i = 0; i < values.Length; i++)
{
    if (values[i] > maxValue)
    {
        maxValue = values[i];
    }

}
Console.WriteLine($"This is the maximum value, {maxValue}");

// Code challenge: Implement a method of the Math class that returns the larger of two numbers
int result = values.Max();
Console.WriteLine($"This is the result, {result}");




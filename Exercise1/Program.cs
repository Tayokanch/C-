// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

//Literal Data types

//1. Int

int number = 10;


//2. Char

Char alphabet = 't';

// 3. String
String myName = "Omotayo";
Console.WriteLine(myName);

//FLOAT
// A float data type has 6 - 9 precision i.e it can only store the maximum number of 9 
float floatNumber = 38.393934903903490494F;
Console.WriteLine(floatNumber);
// Ans = 38.393936

//DOUBLE
// A float data type has 15 - 17 precision i.e it can only store the maximum number of 17

double doubleNumber = 15.123456789987654321D;
Console.WriteLine(doubleNumber);
//Ans = 15.123456789987655

//DECIMAL
//Decimal is used for a number with a fractional component and its best for calculation

decimal decimalNumber = 349.34903932902m + 832.89238239032m;
Console.WriteLine(decimalNumber);
//Ans = 1182.24142171934



//WHAT IS AN IMPLICITLY LOCAL TYPE VARIABLE?
// This is a variable declared with VAR 
// The var keyword is used when the type is obvious from the context.
// e .g

var message = "Hello World";
/// IN this context "message" is a type of string and can not be changed to another type


///EXERCISE
/// Store the following values in variables: Bob, 3, 34.4

string name = "Bob";
int messages = 3;
double temperature = 34.4D;

Console.WriteLine($"Hello {name}, You have {messages} messages in your inbox. The temperature is {temperature} celsius.");



///Convert Fahrenheit to Celcius
///
int fahrenheit = 94;
decimal Celcius = (fahrenheit - 32m) * 5m / 9m;
Console.WriteLine($"{fahrenheit} fahrenheit to Celcius is: {Celcius} ");

 Console.WriteLine(5 / 10);

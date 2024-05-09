// See https://aka.ms/new-console-template for more information


// Mathematics Operation
// Calculate the Grade of Each Student 

// Sophia: 93, 87, 98, 95, 100

//  Nicolas: 80, 83, 82, 88, 85

//  Zahirah:   84, 96, 73, 85, 79

//  Jeong:  90, 92, 98, 100, 97

int[] Sophia = new int[] { 93, 87, 98, 95, 100 };
int[] Nicolas = new int[] { 80, 83, 83, 88, 85 };
int[] Zahirah = new int[] { 84, 96, 73, 85, 79 };
int[] Jeong = new int[] { 90, 92, 98, 100, 97 };
int summation = 0;
for (int i = 0; i < Sophia.Length; i++)
{
    summation += Sophia[i];

}
int result = summation/5 ;
;
Console.WriteLine($"This is {result}%");


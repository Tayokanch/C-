// See https://aka.ms/new-console-template for more information

//Exercise 1

//  Student Grading application that automates the calculation of grades for each student in a class. 
//  The parameters for your application are:

int numberOfTest = 5;
string[] studentNames = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };
int[] SophiaScores = new int[] { 73, 7, 87, 8, 43, 4, 49, 5, 80, 8 };
int[] NicolasScores = new int[] { 80, 8, 67, 6, 91, 9, 46, 4, 52, 5 };
int[] ZahirahScores = new int[] { 52, 5, 85, 8, 69, 6, 80, 8, 72, 7 };
int[] JeongScores = new int[] { 59, 5, 65, 6, 46, 4, 100, 10, 58, 5 };

int[] studentScores = new int[10];
string grade = "";


foreach (string student in studentNames)

{
    int totalScore = 0;

    if (student.ToLower() == "sophia")
    {
        studentScores = SophiaScores;
    }
    else if (student.ToLower() == "nicolas")
    {
        studentScores = NicolasScores;
    }
    else if (student.ToLower() == "zahirah")
    {
        studentScores = ZahirahScores;
    }
    else if (student.ToLower() == "jeong")
    {
        studentScores = JeongScores;
    }

    foreach (int score in studentScores)
    {
        totalScore += score;
    }

    decimal averageScore = (decimal)totalScore / numberOfTest;

    if (averageScore >= 97)
    {
        grade = "A+";
    }
    else if (averageScore >= 93)
    {
        grade = "A";
    }
    else if (averageScore >= 90)
    {
        grade = "A-";
    }
    else if (averageScore >= 87)
    {
        grade = "B+";
    }
    else if (averageScore >= 83)
    {
        grade = "B";
    }
    else if (averageScore >= 80)
    {
        grade = "B-";
    }
    else if (averageScore >= 77)
    {
        grade = "C+";
    }
    else if (averageScore >= 73)
    {
        grade = "C";
    }
    else if (averageScore >= 70)
    {
        grade = "C-";
    }
    else if (averageScore >= 67)
    {
        grade = "D+";
    }
    else if (averageScore >= 63)
    {
        grade = "D";
    }
    else if (averageScore >= 60)
    {
        grade = "D-";
    }
    else
    {
        grade = "F";
    }

    // Print the results
    Console.WriteLine($"{student}\t {averageScore}\t {grade}\t");

}


int[,] registerDailyStartingCash = new int[,] { { 1, 50 }, { 5, 20 }, { 10, 10 }, { 20, 5 } };
int total = 0;
for (int i = 0; i < registerDailyStartingCash.GetLength(0); i++)
{
    for (int j = 0; j < registerDailyStartingCash.GetLength(1); j++)
    {
        total += registerDailyStartingCash[i, j] * registerDailyStartingCash[i, j];


    }
}
Console.WriteLine("Total is : " + total);


/*
///Exercise 2
///
string[] orders = new string[] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string item in orders)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine($"This is {item}");

    }

}

//Exercise 3
// Count how mant zero(0) in this sentence
string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] messageChar = originalMessage.ToCharArray();
int count = 0;
foreach (char i in messageChar)
{
    if (i == 'o')
    {
        count++;
    }
};
Console.WriteLine(count);
*/






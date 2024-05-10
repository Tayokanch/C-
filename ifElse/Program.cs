// See https://aka.ms/new-console-template for more information

//Dice Game

Random dice = new Random();
int roll1 = dice.Next(1, 6);
int roll2 = dice.Next(1, 6);
int roll3 = dice.Next(1, 6);

int totalRoll = roll1 + roll2 + roll3;
Console.WriteLine($"{roll1} {roll2} {roll3}");


if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled tripple , you've gained 6 additional points");
    totalRoll += 6;


}

else if (roll1 == roll2 || roll2 == roll3)
{
    Console.WriteLine("You rolled double, you've gained 4 additional points");
    totalRoll += 4;


}
if (totalRoll < 15)
{
    Console.WriteLine($"Your point is {totalRoll}: You lose!");
}
else
{
    Console.WriteLine($"Your point is {totalRoll}: You Won!");
}


//// Exercise 2
///You've been asked to add a feature to your company's software. 
///The feature is intended to improve the renewal rate of subscriptions to the software. 
///Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. 
///You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

    if(10 < daysUntilExpiration){
        return;
    }
    else if (daysUntilExpiration == 0)
    {
        Console.WriteLine("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
        Console.WriteLine("Your subscription expires within a day! Renew now and save 20 % !");
    }
    else if(daysUntilExpiration >= 5){
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%");
    }
    else if(daysUntilExpiration >= 10){
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }



Random randomGenerator = new Random();
int number = randomGenerator.Next(0,100);

int guess = 0;

while (guess != number)
{
    Console.Write("What is the Magic Number? ");
    guess = int.Parse(Console.ReadLine());

    if (number > guess)
    {
        Console.WriteLine("Higher");
    }
    else if (number < guess)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("Good job. You guessed it!");
    }
}
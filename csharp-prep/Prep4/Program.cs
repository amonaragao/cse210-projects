List<int> numbers = new List<int>();

int newNumber = -1;
while (newNumber != 0)
{
    Console.Write("Enter a new number (if you finished enter 0): ");
    newNumber = int.Parse(Console.ReadLine());

    if (newNumber != 0)
    {
        numbers.Add(newNumber);
    }
}

int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

Console.WriteLine($"The sum is: {sum}");

float average = ((float)sum) / numbers.Count;
Console.WriteLine ($"The average is: {average}");

int largest = numbers[0];

foreach (int number in numbers)
{
    if (number > largest)
    {
        largest = number;
    }
}

Console.WriteLine($"The largest is: {largest}");
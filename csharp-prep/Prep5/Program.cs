//I created the first function "DisplayWelcome", then I created a "variable" for each data, then we created a function for each variable
DisplayWelcome();

string name = PromptName();
int number = PromptNum();
int sqr = SquareNum(number);
DisplayResult(name, sqr);

//Function for variable "Display Welcome" 
static void DisplayWelcome()
{
    System.Console.WriteLine("Welcome to the program!");
}
//Function for variabel "PromptName"
static string PromptName()
{
    System.Console.WriteLine("What is your name: ");
    string name = Console.ReadLine();
    return name;
}
//Function for variable "PromptNum"
static int PromptNum()
{
    System.Console.WriteLine("What is favorite number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}
//Function for variable "SquareNum"
static int SquareNum(int number)
{
    int sqr = number * number;
    return sqr;
}
//"static void" serves to call the complete code and it will always be in the last function. It does not receive the "return" command
static void DisplayResult(string name, int sqr)
{
    System.Console.WriteLine($"Brother {name}, the square of your number is {sqr}");
}
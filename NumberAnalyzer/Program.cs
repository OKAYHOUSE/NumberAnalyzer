//User Input, Conditionals
//Ask for user's name
Console.Write("Hi, this is NumberAnalyzer, what is your name? ");
string name = Console.ReadLine();

//Set up program to continue running (loops)
bool keepLooping = true;
while (keepLooping)
{

//Get integer between 1 and 100; exclude 10
    Console.Write("\n" + name + ", please enter a number between 1 and 100 (excluding the number 1 and 100). "); 
    int number = int.Parse(Console.ReadLine());

//Add validation that number is a postive integer betweeen 1 and 100      
    if (number < 2 || number >= 100)
{
    Console.WriteLine("\n" + name + ", you entered an invalid option.");
}
    else if (number % 2 != 0 && number < 60)
{
    Console.WriteLine("\n" + number + " is odd and less than 60.");
}
    else if (number % 2 == 0 && number >= 2 && number <= 24)
{
    Console.WriteLine("\n" + name + ", " + number + " is even and less than 25.");
}
    else if (number % 2 == 0 && number >= 26 && number <= 60)
{
    Console.WriteLine("\n" + name + ", " + number + " is even and between 26 and 60 inclusive.");
}
    else if (number % 2 == 0 && number > 60)
{
    Console.WriteLine("\n" + name + ", " + number + " is even and greater than 60.");
}
    else if (number % 2 != 0 && number > 60)
{
    Console.WriteLine("\n" + name + ", " + number + " is odd and greater than 60.");
}

//Give user the option to leave or continue
    Console.WriteLine("\n" + name + ", would you like to start over? Y/N");
    string answer = Console.ReadLine();

    if (answer == "Y" || answer == "y")
{ keepLooping = true;
    continue;
}
    if (answer == "N" || answer == "n")
{ keepLooping = false; Console.WriteLine("\n" + "Goodbye, " + name);
    break;
}

}

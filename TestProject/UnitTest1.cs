using System.ComponentModel.Design;

string? input;
int numericValue = 0;
bool validIntergerNumber = false;

do
{
    Console.WriteLine("Enter an integer value between 5 and 10");
    input = Console.ReadLine();
    bool validNumber = false;
    validNumber = int.TryParse(input, out numericValue);

    if (validNumber)
    {
        if (numericValue >= 5 && numericValue <= 10)
            validIntergerNumber = true;
    }
    else
        Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (!validIntergerNumber);

if (numericValue >= 5 && numericValue <= 10)
    Console.WriteLine($"You entered {numericValue}. This is correct");




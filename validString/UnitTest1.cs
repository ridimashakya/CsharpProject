String? readResult;
String role = "";
bool validEntry = false;


do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        role = readResult.Trim();

        if (role.ToLower() == "administrator" || role.ToLower() == "manager" || role.ToLower() == "user")
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered,\"{role}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    }
} while (validEntry == false);

Console.WriteLine($"Your input value ({role}) has been accepted.");
readResult = Console.ReadLine();
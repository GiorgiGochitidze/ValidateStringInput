string[] roles = { "Administrator", "Manager", "User" };
bool validStatus = false;
string? readResult;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do {
    readResult = Console.ReadLine()?.Trim().ToLower();
    bool matchFound = false;

    foreach (string role in roles) {
        if (role.Trim().ToLower() == readResult) {
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
            validStatus = true;
            matchFound = true;
            break;
        }
    }

    if (!matchFound) {
        Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (!validStatus);
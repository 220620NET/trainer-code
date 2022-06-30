using System.Collections.Generic;
//must include this line for generic collections such as List, Dictionary, HashSet, etc etc.

Dictionary<string, string> pwLookupTable = new Dictionary<string, string>();

pwLookupTable.Add("jsong", "password123");
pwLookupTable.Add("sam", "pass567");

while(true)
{
    Console.WriteLine("Enter Username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password: ");
    string pw = Console.ReadLine();
    pwLookupTable.Add(username, pw);
    Console.WriteLine("Do you want to add another?");
    string response = Console.ReadLine();
    if(response == "n")
    {
        break;
    }
}

foreach(KeyValuePair<string, string> kvp in pwLookupTable)
{
    Console.WriteLine(kvp);
}

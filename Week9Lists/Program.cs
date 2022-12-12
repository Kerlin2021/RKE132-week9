string folderPath = @"c:C:\Users\siimk\OneDrive\Desktop\TKTK\Programeerimine\test";
string fileName = "ShoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();    

if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created.");
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}



static List<string> GetItemsFromUser()
{
    List<string> userlist = new List<string>();

    while (true)
    {
        Console.WriteLine("Add on item (add) /exit (exit):");
        string userchoice = Console.ReadLine();

        if (userchoice == "add")
        {
            Console.WriteLine("Enter a item:");
            string useritem = Console.ReadLine();
            userlist.Add(useritem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userlist;
}

static void showItemsFromList (List<string> somelist)
    
{
    Console.Clear();

    int listleight = somelist.Count;
    Console.WriteLine($"You have added {listleight} items to your shopping list.");
    int i = 1;
    foreach (string item in somelist)
    {
        Console.WriteLine($"{i}.{item}");
        i++;
    }
}

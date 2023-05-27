// See https://aka.ms/new-console-template for more information
string folderPath = @&quot; C:\data & quot; ;
string filename = &quot; shoppingList.txt & quot; ;
string filePath = Path.Combine(folderPath, filename);
List & lt; string&gt; myShoppingList = new List& lt; string&gt; ();
if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($&quot; File { filename}
    has been created.& quot;);
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}

static List &lt; string&gt; GetItemsFromUser()
{
    List & lt; string&gt; myShoppingList = new List& lt; string&gt; ();
    while (true)
    {
        Console.WriteLine(&quot; Add an item(add) / Exit(exit):&quot;);
        string userChoice = Console.ReadLine();
        if (userChoice == &quot; add & quot;)
{
            Console.WriteLine(&quot; Enter an item: &quot;);
            string userItem = Console.ReadLine();
            myShoppingList.Add(userItem);
        }
else
        {
            Console.WriteLine(&quot; Bye! & quot;);

            break;
        }
    }
    List & lt; string&gt; userList = null;
    return userList;
}

static void ShowItemsFromList(List&lt; string&gt; someList)
{
    Console.Clear();
    int listLength = someList.Count;
    Console.WriteLine($&quot; You have added { listLength}
    items to your shopping list.& quot;);
    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($&quot;
        { i}. { item}
        &quot;);
        i++;
    }
}

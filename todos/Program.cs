List<string> todoList = new List<string>();

while (true)
{
    Console.WriteLine("Enter a command (add/remove/show/exit):");
    string command = Console.ReadLine();

    switch (command)
    {
        case "add":
            Console.WriteLine("Enter a new to-do item:");
            string todoItem = Console.ReadLine();
            todoList.Add(todoItem);
            Console.WriteLine("To-do item added!");
            break;
        case "remove":
            Console.WriteLine("Enter the index of the item to remove:");
            int indexToRemove = int.Parse(Console.ReadLine());
            if (indexToRemove >= 0 && indexToRemove < todoList.Count)
            {
                todoList.RemoveAt(indexToRemove);
                Console.WriteLine("To-do item removed!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
            break;
        case "show":
            Console.WriteLine("To-do list:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i}: {todoList[i]}");
            }
            break;
        case "exit":
            Console.WriteLine("Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
}
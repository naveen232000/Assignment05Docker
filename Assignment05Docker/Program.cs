// See https://aka.ms/new-console-template for more information
using Assignment05Docker;

Console.WriteLine("Welcome to Players Management System");
while (true)
{
    Console.WriteLine("\nEnter your choice : \n1 GetAll Players\n2 GetById\n3 Exit\n");
    int num =int .Parse(Console.ReadLine());
    switch (num)
    {
        case 1:
            {
                PlayerManagement.GetAllPlayers();
                break;
            }
        case 2:
            {
                Console.WriteLine("\nEnter Player Id :");
                int id=int .Parse(Console.ReadLine());
                PlayerManagement.GetPlayerById(id);
                break;
            }
        case 3:
        {
            Environment.Exit(0);
            break;
            }
        default:
            {
                Console.WriteLine("Enter Correct Choice");
                break;
            }
    }
}

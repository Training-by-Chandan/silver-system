namespace ConsoleApps.Db.EF.CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = "Y";
            do
            {
                Console.Clear();
                Console.WriteLine("Press\n1. to Read all records\n2 to Get by ID\n3 to Create the record\n4 to Edit the records\n5 to Delete the records");
                var choice = Convert.ToInt32(Console.ReadLine());
                SelectChoice(choice);

                Console.WriteLine("Do you want to continue more? (Y/N)");
                res = Console.ReadLine();
            } while (res.ToUpper() == "Y");
        }

        private static void SelectChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    DatabaseConnection.Read();
                    break;
                case 2:
                    DatabaseConnection.ReadById();
                    break;
                case 3:
                    DatabaseConnection.Create();
                    break;
                case 4:
                  DatabaseConnection.Edit();
                    break;
                case 5:
                    DatabaseConnection.Delete();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
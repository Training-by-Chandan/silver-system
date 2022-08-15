namespace ConsoleApps.Db.EF.CodeFirst
{
    public static class DbConnection
    {
        private static DefaultContext db = new DefaultContext();  
        public static void ReadAll()
        {
            var data = db.PersonInfos;
            if (data.Count()==0)
            {
                Console.WriteLine("No Records are there in table");
                return;
            }

            foreach (var item in data)
            {
                Console.WriteLine($"Id : {item.Id}");
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine("======================================");
            }
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the ID");
            var id = Convert.ToInt32(Console.ReadLine());

            var data = db.PersonInfos.Find(id);
            if (data==null)
            {
                Console.WriteLine("No records found");
            }
            else
            {
                Console.WriteLine($"Id : {data.Id}");
                Console.WriteLine($"Name : {data.Name}");
                Console.WriteLine($"Email : {data.Email}");
            }
        }

        public static void Create()
        {
            var person = new PersonInfo();
            Console.WriteLine("Enter the Name");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            person.Email = Console.ReadLine();

            db.PersonInfos.Add(person);
            db.SaveChanges();
        }

        public static void Edit()
        {
          
            Console.WriteLine("Enter the Id");
            var Id = Convert.ToInt32(Console.ReadLine());
            var existing = db.PersonInfos.Find(Id);
            if (existing!=null)
            {
                Console.WriteLine("Enter the Name");
                existing.Name = Console.ReadLine();
                Console.WriteLine("Enter the Email");
                existing.Email = Console.ReadLine();

                db.PersonInfos.Update(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
           
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the Id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.PersonInfos.Find(id);
            if (existing!=null)
            {
                db.PersonInfos.Remove(existing);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
    }
}
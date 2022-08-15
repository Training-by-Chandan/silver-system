namespace ConsoleApps.Db.EF.CodeFirst
{
    public static class DatabaseConnection
    {
        public static DatabaseContext db = new DatabaseContext();

        public static void Read()
        {
            var data = db.Students;

            Console.WriteLine("Data from the database");
            Console.WriteLine("==============================================");
          
            foreach (var item in data)
          
            {
                Console.WriteLine($"Id : {item.StudentNumber}");
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Email : {item.Email}");
                Console.WriteLine("==============================================");
            }
        }

        public static void ReadById()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var existing = db.Students.Find(id);
            if (existing==null)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                Console.WriteLine($"Id : {existing.StudentNumber}");
                Console.WriteLine($"Name : {existing.Name}");
                Console.WriteLine($"Email : {existing.Email}");
            }
        }

        public static void Create()
        {
            var student = new Student();
            Console.WriteLine("Enter the name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the email");
            student.Email = Console.ReadLine();

            db.Students.Add(student);
            db.SaveChanges();
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var student =db.Students.Find(id);
            if (student!=null)
            {
                Console.WriteLine("Enter the name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter the email");
                student.Email = Console.ReadLine();

                db.Students.Update(student);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the id");
            var id = Convert.ToInt32(Console.ReadLine());

            var student = db.Students.Find(id);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Record not found");
            }
        }
    }
}
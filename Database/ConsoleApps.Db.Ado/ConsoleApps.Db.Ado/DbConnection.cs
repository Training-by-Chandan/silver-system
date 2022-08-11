using System.Data.SqlClient;

namespace ConsoleApps.Db.Ado
{
    public class DbConnection
    {
        public static readonly string _connectionString = "server=DESKTOP-PT71T7O\\SQLBHAGAT;database=Silver.Console.Db.Ado;integrated security=true";
        public static void ReadAll()
        {
            ///1. Create the query
            string query= "select * from person";

            ReadData(query);
        }

        public static void GetById()
        {
            Console.WriteLine("Enter the ID");
            var id = Convert.ToInt32(Console.ReadLine());
            ///1. Create the query
            string query = "select * from person where id = " + id;

            ReadData(query);
        }

        private static void ReadData(string query)
        {
            ///2. create sql connection object
            SqlConnection con = new SqlConnection(_connectionString);

            ///3. Create sql command object
            SqlCommand cmd = new SqlCommand(query, con);

            ///4.open the connection
            con.Open();

            ///5. Execute commands 
            var res = cmd.ExecuteReader();

            Console.WriteLine("Data from the database");
            Console.WriteLine("==============================================");
            ///6. do the work
            while (res.Read())
            {
                Console.WriteLine($"Id : {res.GetFieldValue<int>(0)}");
                Console.WriteLine($"Name : {res.GetFieldValue<string>(1)}");
                Console.WriteLine($"Email : {res.GetFieldValue<string>(2)}");
                Console.WriteLine("==============================================");
            }

            ///7. close the connection
            con.Close();
        }

        public static void Create()
        {
            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();

            string query = $"Insert into person (Name, Email) values ('{name}','{email}')";

            RunNonQuery(query);
        }

        public static void Edit()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            var email = Console.ReadLine();

            string query = $"Update person set Name='{name}', Email = '{email}' where id={id}";

            RunNonQuery(query);
        }
        public static void Delete()
        {
            Console.WriteLine("Enter the Id");
            var id = Console.ReadLine();
            string query = $"delete from person where id={id}";

            RunNonQuery(query);
        }

        private static void RunNonQuery(string query)
        {
            ///2. create sql connection object
            SqlConnection con = new SqlConnection(_connectionString);

            ///3. Create sql command object
            SqlCommand cmd = new SqlCommand(query, con);

            ///4.open the connection
            con.Open();

            ///5. Execute commands 
            var res = cmd.ExecuteNonQuery();

            ///6. close the connection
            con.Close();
        }
    }
}
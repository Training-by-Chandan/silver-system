using System;
using System.Linq;
using System.Reflection;

namespace Silver.ConsoleApp
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute()
        {
        }

        public string FullName { get; set; }
        public string Address { get; set; }
    }

    public class TestingForAttribute
    {
        [Custom(FullName = "Broadway Pvt. Ltd.", Address = "KTM")]
        public string Broadway { get; set; }

        // [Custom(FullName = "Infosys Pvt. Ltd.", Address = "KTM")]
        public string Infosys { get; set; }
        [Custom(Address ="ABC",FullName ="XYZ")]
        public string Test { get; set; }

        public override string ToString()
        {
            var asm = Assembly.GetExecutingAssembly();
            var types = asm.GetTypes().FirstOrDefault(p => p.Name == "TestingForAttribute");
            var prop = types.GetProperties();
            foreach (var item in prop)
            {
                var attr = item.GetCustomAttribute<CustomAttribute>();
                if (attr != null)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine($"Full Name = {attr.FullName}");
                    Console.WriteLine($"Address = {attr.Address}");
                    Console.WriteLine("======================================");
                }
            }
            //string str = "Silver.ConsoleApp.Delegates";
            //var obj = asm.CreateInstance(str);
            //var del = obj as Delegates;
            //if (del!=null)
            //{
            //    del.Run();
            //}
            return "Here we are testing for Attributes";
        }
    }

    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    internal sealed class MyAttribute : Attribute
    {
        // See the attribute guidelines at
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        private readonly string positionalString;

        // This is a positional argument
        public MyAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            throw new NotImplementedException();
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
    }
}

namespace Silver.ConsoleApp
{
    public class Templates<T1, T2, T3>
    {
        public T1 VarOne { get; set; }
        public T2 VarTwo { get; set; }
        public T3 VarThree { get; set; }

        public void FunctionOne(T1 item1, T2 item2, T3 item3)
        {
        }
    }

    public class TemplatesV2<T1, T2, T3>
        where T1 : struct
        where T2 : class
        where T3 : IShape, IAbc
    {
        public T1 VarOne { get; set; }
        public T2 VarTwo { get; set; }
        public T3 VarThree { get; set; }

        public void FunctionOne(T1 item1, T2 item2, T3 item3)
        {
        }
    }

    public class NonTemplatedClass
    {
        public void FunctionOne<T1, T2>(T1 item1, T2 item2, T1 item3, T2 item4)
            where T1 : struct
            where T2 : IShape
        {
        }
    }
}

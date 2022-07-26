using System;
using System.Collections.Generic;
using System.Threading;//for threads
using System.Threading.Tasks;  //for tasks

namespace Silver.ConsoleApp
{
    public class ParallelProgramming
    {
        private CancellationToken token;
        private CancellationTokenSource tokenSource;

        public async void Run()
        {
            //FunctionOne();
            //FunctionTwo();

            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);

            //t1.Start();
            //t2.Start();

            //Task t3 = new Task(FunctionOne);
            //Task t4 = new Task(FunctionTwo);

            //t3.Start();
            //t4.Start();

            //Task<string> t5 = new Task<string>(FunctionThree);
            //Task<int> t6 = new Task<int>(FunctionFour);

            //t5.Start();
            //t6.Start();
            //// () => {
            ////
            //// }
            //var t7 = Task.Run(() =>
            //{
            //    Console.WriteLine($"Function 4 returns : {t6.Result}");
            //});

            //var t8 = Task.Run(() =>
            //{
            //    Console.WriteLine($"Function 3 returns : {t5.Result}");
            //});

            //var resFive = FunctionFive();
            //var resSix = FunctionSix();

            //Console.WriteLine($"Function Five returns {resFive.Result}");
            //Console.WriteLine($"Function Six returns {resSix.Result}");

            tokenSource = new CancellationTokenSource();
            this.token = tokenSource.Token;

            FunctionFive();
            FunctionSix();

            //Thread.Sleep(7000);
        }

        public void FunctionOne()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function One says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            //return 1;
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Two says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public string FunctionThree()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function Three says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return "Function three is now completed";
        }

        public int FunctionFour()
        {
            for (int i = 0; i < 15; i++)
            {
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Four says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 100;
        }

        public async Task<string> FunctionFive()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function Five says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            tokenSource.Cancel();
            Console.WriteLine("Function five ended and cancelling function six");
            return "Function three is now completed";
        }

        public async Task<int> FunctionSix()
        {
            for (int i = 0; i < 15; i++)
            {
                token.ThrowIfCancellationRequested();
                //if (token.IsCancellationRequested)
                //{
                //    Console.WriteLine("Tasks is cancelled");
                //    return -1;
                //}
                await Task.Delay(1000);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Function Six says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return 100;
        }

        public async Task<string> Function(int loop, string name)
        {
            for (int i = 0; i < loop; i++)
            {
                await Task.Delay(900);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Function {name} says {i} at {DateTime.Now}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return $"Function {name} is now completed";
        }
    }
}

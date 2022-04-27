using System;
using System.Threading;
using System.Threading.Tasks;

namespace Octo.Robot
{
    public class MultiThreading
    {
        public void ThreadedExample()
        {
            //Thread t1 = new Thread(FunctionOne);
            //Thread t2 = new Thread(FunctionTwo);
            //t1.Start();
            //t2.Start();
        }

        public void TasksExample()
        {
            //Task t1 = new Task(FunctionOne);
            //Task t2 = new Task(FunctionTwo);
            //t1.Start();
            //t2.Start();

            var tokenSource = new CancellationTokenSource();
            ExceptionFunction();
            var res = TaskOne(15, "Task One", 500);
            var res2 = TaskOne(20, "Task Two", 750);
            var res3 = TaskOne(10, "Task Three", 600);
            var t1 = Task.Factory.StartNew(() => FunctionOne(tokenSource.Token));

            //Thread.Sleep(5000);
            tokenSource.CancelAfter(5000);

            Console.WriteLine(res);
        }

        public int FunctionOne(CancellationToken token)
        {
            for (int i = 0; i < 10; i++)
            {
                token.ThrowIfCancellationRequested();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Function one => Loop {i}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
            }
            return 1;
        }

        public static void ExceptionFunction()
        {
            System.Diagnostics.StackTrace s = new System.Diagnostics.StackTrace();
            Console.WriteLine(s.ToString());
            throw new Exception("Throwing this intentionally");
        }

        public void FunctionTwo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Function two => Loop {i}");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
            }
        }

        public async Task<int> TaskOne(int x, string name, int delay)
        {
            for (int i = 0; i < x; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{name} => Loop {i}");
                Console.ForegroundColor = ConsoleColor.White;
                await Task.Delay(delay);
            }
            return 1;
        }

        //public async Task<string> TaskTwo(int x, string name)
        //{
        //    for (int i = 0; i < x; i++)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        System.Console.WriteLine($"{name} => Loop {i}");
        //        Console.ForegroundColor = ConsoleColor.White;
        //        await Task.Delay(1500);
        //    }
        //    return "Two";
        //}
    }
}
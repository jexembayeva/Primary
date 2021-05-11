using PrimaryBase;
using System;

namespace PrimaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\algorithms\03._Алгебраические_алгоритмы\5.Primes-19350-906510\5.Primes";

            Console.WriteLine("-------------------EratosthenesLinier------------------------");
            ITask eratosthenesLinierTask = new SieveOfEratosthenesLinierTask();

            Tester eratosthenesLinierTester = new Tester(eratosthenesLinierTask, path);
            eratosthenesLinierTester.RunTests();

            
            Console.WriteLine("-------------------EratosthenesOptimized------------------------");
            ITask eratosthenesOptimizedTask = new SieveOfEratosthenesOptimizedTask();

            Tester eratosthenesOptimizedTester = new Tester(eratosthenesOptimizedTask, path);
            eratosthenesOptimizedTester.RunTests();

            Console.WriteLine("-------------------EratosthenesSimple------------------------");
            ITask eratosthenesSimpleTask = new SieveOfEratosthenesSimpleTask();

            Tester eratosthenesSimpleTester = new Tester(eratosthenesSimpleTask, path);
            eratosthenesSimpleTester.RunTests();


            Console.WriteLine("-------------------IterativeOptimized------------------------");
            ITask iterativeOptimizedTask = new IterativeOptimizedTask();

            Tester iterativeOptimizedTester = new Tester(iterativeOptimizedTask, path);
            iterativeOptimizedTester.RunTests();

            Console.WriteLine("-------------------Iterative------------------------");
            ITask iterativeTask = new IterativeTask();

            Tester iterativeTester = new Tester(iterativeTask, path);
            iterativeTester.RunTests();

            Console.ReadKey();
        }
    }
}

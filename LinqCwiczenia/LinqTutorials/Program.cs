using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("\nt1--------------------");
            var t1 = LinqTasks.Task1();
            foreach (var t in t1)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt2--------------------");
            var t2 = LinqTasks.Task2();
            foreach (var t in t2)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt3--------------------");
            var t3 = LinqTasks.Task3();
            Console.WriteLine(t3);
            
            Console.WriteLine("\nt4--------------------");
            var t4 = LinqTasks.Task4();
            foreach (var t in t4)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt5--------------------");
            var t5 = LinqTasks.Task5();
            foreach (var t in t5)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt6--------------------");
            var t6 = LinqTasks.Task6();
            foreach (var t in t6)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt7--------------------");
            var t7 = LinqTasks.Task7();
            foreach (var t in t7)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt8--------------------");
            var t8 = LinqTasks.Task8();
            Console.WriteLine(t8);
            
            Console.WriteLine("\nt9--------------------");
            var t9 = LinqTasks.Task9();
            Console.WriteLine(t9);
            
            Console.WriteLine("\nt10--------------------");
            var t10 = LinqTasks.Task10();
            foreach (var t in t10)
            {
                Console.WriteLine(t);
            }
            
            Console.WriteLine("\nt11--------------------");
            var t11 = LinqTasks.Task11();
            foreach (var t in t11)
            {
                Console.WriteLine(t);
            }
            
            // Console.WriteLine("\nt12--------------------");
            // var t12 = LinqTasks.Task12();
            // foreach (var t in t12)
            // {
            //     Console.WriteLine(t);
            // }
            
            Console.WriteLine("\nt13--------------------");
            int[] t13_arg = {1,1,1,1,1,1,10,1,1,1,1};
            var t13 = LinqTasks.Task13(t13_arg);
            Console.WriteLine(t13);
            
            
            var t14 = LinqTasks.Task14();
            var t15 = LinqTasks.Task15();
            var t16 = LinqTasks.Task16();
            
        }
    }
}

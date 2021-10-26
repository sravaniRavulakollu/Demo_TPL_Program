using System;

using System.Threading.Tasks;

namespace DEmo_TPL_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo for TSA Parellel Library");
            //Task.Factory.StartNew(() =>
            var task0=new Task(()=>
            {
                Console.WriteLine("this is the first method to create and start a task using TPL");
            });
            task0.Start();
            var task1=new Task(()=>
             {
                  Console.WriteLine("here is the second task created using new  keyword");
             });
            task0.Wait();
            task1.Start();
            task1.Wait();
            Console.WriteLine("task is execution");
            Console.ReadKey();
        }
    }
}

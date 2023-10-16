using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int x = 0; x < 6; x++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + x);
                Thread.Sleep(1500);
            }
        }
    }
}


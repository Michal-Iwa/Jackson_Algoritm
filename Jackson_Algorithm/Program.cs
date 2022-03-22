using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jackson_Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Problem p = new Problem();
            p.Read_tasks_from_file();
            p.ScheduleTasks(p.listoftasks);
            foreach (Task i in p.listoftasks)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("Cmax = " + p.Cmax as string);
            string elapsedMs = watch.ElapsedMilliseconds.ToString();
            Console.WriteLine("Program obliczal przez " + elapsedMs as string + " milisekund ");
            long memory = GC.GetTotalMemory(true);
            Console.WriteLine("Program zajał " + memory as string + " bajtow pamieci ");
            Console.ReadLine();
        }
        
    }
}

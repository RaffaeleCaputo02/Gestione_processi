using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppProcessi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei processi");
            Process.Start("Notepad.exe");
            Process.Start("Notepad.exe", @"C:\Users\docente\Source\Repos\Gestione_processi\AppProcessi\HelloWorld.txt");
            Process.Start("Chrome.exe", @"https://www.youtube.it");
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\docente\Source\Repos\Gestione_processi\AppProcessi\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            

            var processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                if(p.ProcessName=="notepad")
                {
                    p.Kill();
                }
            }
            Console.WriteLine("Programma terminato!");
            Console.ReadLine();

        }
    }
}

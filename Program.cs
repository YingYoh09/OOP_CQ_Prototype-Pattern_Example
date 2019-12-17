using System;
using System.Collections.Generic;

namespace temp
{
    class Computer
    {
        public string name { get; set; }
        private List<string> apps = new List<string>();

        public void addApp(string name)
        {
            apps.Add(name);
        }
        public Computer()
        {
            name = "name";
            addApp("Chrome");
            addApp("Word");
            addApp("Excel");
            addApp("Access");
            addApp("Sublime Text");
            addApp("VS code");
            addApp("Garena");
            for (int i = 0; i < 5000; i++)
            {
                addApp("app " + i.ToString());
            }
        }
    }
    class MyProgram
    {
        static void Main()
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            Computer A = new Computer();
            A.name = "may_1";

            //them app
            for (int i = 0; i < 1000; i++)
            {
                A.addApp("New app");
            }

            int numberOfNewComputer = 5000;
            Computer[] arr = new Computer[numberOfNewComputer];
            for (int i = 0; i < numberOfNewComputer; i++)
            {
                arr[i] = new Computer();
                arr[i].name = "may_" + i.ToString();

                //them app
                for (int j = 0; j < 1000; j++)
                {
                    arr[i].addApp("New app may " + i.ToString());
                }
            }


            timer.Stop();
            Console.WriteLine("Time elapsed : {0} Miliseconds", timer.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }

}
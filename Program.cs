using System;
using System.Collections.Generic;

namespace temp
{
    class Computer : ICloneable
    {
        public string name { get; set; }
        private List<string> apps = new List<string>();

        public void addApp(string name)
        {
            apps.Add(name);
        }
        public object Clone()
        {
            Computer temp = (Computer)this.MemberwiseClone();

            temp.apps = new List<string>(apps);

            return temp;
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

            int n = 10000;
            Computer[] arr = new Computer[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = (Computer)A.Clone();
                arr[i].name = "may_" + i.ToString();
            }

            timer.Stop();
            Console.WriteLine("Time elapsed : {0} Miliseconds", timer.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }

}
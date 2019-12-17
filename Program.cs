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

        public void changeApp(int index, string data)
        {
            apps[index] = data;
        }
    }
    class MyProgram
    {
        static void Main()
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();

            Computer A = new Computer();
            A.name = "may_1";

            //them app cua A
            for (int i = 0; i < 1000; i++)
            {
                A.addApp("New app");
            }

            int numberOfNewComputer = 5000;
            Computer[] arr = new Computer[numberOfNewComputer];
            for (int i = 0; i < numberOfNewComputer; i++)
            {
                arr[i] = (Computer)A.Clone();
                arr[i].name = "may_" + i.ToString();

                //sua thanh app cua moi may rieng
                for (int j = 5000; j < 6000; j++)
                {
                    arr[i].changeApp(j, "New app may " + i.ToString());
                }

            }

            timer.Stop();
            Console.WriteLine("Time elapsed : {0} Miliseconds", timer.ElapsedMilliseconds);
            Console.ReadLine();

        }
    }

}
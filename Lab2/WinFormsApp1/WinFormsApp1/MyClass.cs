using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MyClass : Interface1, Interface2
    {
        [CommandLine("publicStr")]
        public string publicStr;
        private string privateStr;
        [CommandLine("publicBool")]
        public bool protectedBool;
        [CommandLine("publicInt")]
        public int publicI;
        public static string? staticStr = "staticStr";

        public int Method1(string str)
        {
            Print("Вызван Method1");
            Print($"result:{str}");
            return 1;
        }

        public void Method2()
        {
            Print("Вызван Method2");
        }

        public void Interface1Method1()
        {
            Print("Вызван Interface1Method1");
        }

        public void Interface1Method2(string str)
        {
            Print("Вызван Interface1Method2");
        }

        public void Interface2Method1()
        {
            Print("Вызван Interface2Method1");
        }

        public void Interface2Method2(string str)
        {
            Print("Вызван Interface2Method2");
        }

        public MyClass() { }
        public MyClass(string str)
        {
            publicStr = str;
        }

        private void Print(string str)
        {
            Program.form.LogsBox.Text += str + Environment.NewLine;
        }
    }
}

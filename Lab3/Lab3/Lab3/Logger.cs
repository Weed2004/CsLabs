using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Logger
{
    public static void Print(string message)
    {
        Program.form.logsTextBox.Text+=message+Environment.NewLine;
    }
}

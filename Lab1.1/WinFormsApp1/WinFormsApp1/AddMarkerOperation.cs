using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class AddMarkerOperation : IFileOperation
    {
        public bool Accept(string fileName)
        {
            string extention = Path.GetExtension(fileName);
            if(extention == ".txt")
            {
                return true;
            }
            return false;

        }

        public void Proccess(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            sw.WriteLine("MARKER");
            sw.Close();
        }
    }
}

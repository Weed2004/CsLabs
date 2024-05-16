using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FirstToUpperCaseOperation : IFileOperation
    {
        public bool Accept(string fileName)
        {
            if (fileName[0] == Char.ToUpper(fileName[0]))
            {
                return true;
            }
            return false;
        }

        public void Proccess(string fileName)
        {
            StringBuilder sb = new StringBuilder(Path.GetFileName(fileName));
            sb[0] = Char.ToUpper(sb[0]);
            string newFileName = Path.GetDirectoryName(fileName) + "\\" + sb.ToString();
            File.Move(fileName, newFileName);
        }
    }
}

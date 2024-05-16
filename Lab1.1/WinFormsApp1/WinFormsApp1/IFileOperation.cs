using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IFileOperation
    {
        bool Accept(string fileName);
        void Proccess(string fileName);
    }
}

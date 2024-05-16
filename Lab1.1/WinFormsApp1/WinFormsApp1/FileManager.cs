using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class FileManager
    {
        private List<IFileOperation> operations = new List<IFileOperation>();
        public List<string> files = new List<string>();
        private string DIR_PATH = "H:\\ВУЗ\\3 курс 2 семестр\\C#\\Lab1.1\\WinFormsApp1\\WinFormsApp1\\test\\";

        public FileManager()
        {
            files = InitFiles();
            operations.Add(new FirstToUpperCaseOperation());
            operations.Add(new AddMarkerOperation());
        }
        private List<string> InitFiles()
        {
            List<string> files = new List<string>();

            files = Directory.GetFiles(DIR_PATH).ToList();

            return files;
        }

        public void ActiveSearch()
        {
            List<string> newFiles = Directory.GetFiles(DIR_PATH).ToList();
            foreach (string file in newFiles)
            {
                if (!files.Contains(file))
                {
                    foreach (IFileOperation operation in operations)
                    {
                        if (operation.Accept(file))
                        {
                            operation.Proccess(file);
                        }
                    }
                }
            }
            files = InitFiles();
        }
    }
}

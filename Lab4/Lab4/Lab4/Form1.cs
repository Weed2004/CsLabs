using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private List<double> PIList = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void GeneratePI(object numOfPoints)
        {
            int? numOfPointsInt = numOfPoints as int?;
            if (numOfPointsInt != null&&numOfPointsInt>0)
            {
                int side = 200000;
                double radius = side / 2;
                int inboxPoints = 0;
                Random random = new Random();

                for(int i = 0; i < numOfPointsInt.Value; i++)
                {
                    int x = random.Next((int)-radius,(int)radius+1);
                    int y = random.Next((int)-radius, (int)radius + 1);
                    
                    if(Math.Pow(y,2)<=Math.Pow(radius,2)-Math.Pow(x,2))
                    {
                        inboxPoints++;
                    }
                }

                double PI = ((double)inboxPoints/(double)numOfPointsInt.Value)*4;
                Logger.Print($"Число PI, рассчитанное потоком {Thread.CurrentThread.Name}: {PI}, Количество входящих точек: {inboxPoints}");
                PIList.Add(PI);
            }
            else
            {
                Logger.Print("Недопустимое кол-во точек!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(GeneratePI);
            thread1.Name = "1";
            Thread thread2 = new Thread(GeneratePI);
            thread2.Name = "2";

            thread1.Start(Convert.ToInt32(numOfPointsTextBox.Text));
            Thread.Sleep(100);
            thread2.Start(Convert.ToInt32(numOfPointsTextBox.Text));

            thread1.Join();
            thread2.Join();

            Logger.Print("Все потоки завершили свою работу!");
            double PI = PIList.Sum(x => x) / PIList.Count;
            Logger.Print($"Итоговое число PI: {PI}");
        }
    }
}

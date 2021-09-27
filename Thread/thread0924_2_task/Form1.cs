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

namespace thread0924_2_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("UI 스레드");
                Thread.Sleep(1000);
            }

            // task1과 task2는 동일한 동작을 수행(둘 다 delegate)
            Task task1 = new Task(new Action(showAction));
            task1.Start();

            Task task2 = new Task(delegate { showDelegate(); });
            task2.Start();

            // task3도 동일한 동작을 수행(람다식 활용)
            Task task3 = new Task(() => showLamda());
            task3.Start();

            // 메서드 호출이 아닌 태스크 내 선언
            Task task4 = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("task4 동작");
                    Thread.Sleep(1000);
                }
            });
            task4.Start();

            // async를 활용한 task활용 
            Task.Run(() => doWork());
            Task.Run(() => doWork2());
            Thread thread = new Thread(new ThreadStart(showAction));
        }

        async Task doWork()
        {
            await Task.Run(() => showDoWork());
        }

        async Task doWork2()
        {
            // getSum읜 메인스레드에서 선언된 메서드 -> task에서 그 return값을 쓰려면 FromResult를 써야 함.
            int sum = await Task.FromResult(getSum(100, 200));
            Console.WriteLine($"결과 : {sum}"); 
        }

        int getSum(int a, int b)
        {
            return a + b;
        }

        void showDoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("showDoWork 동작");
                Thread.Sleep(1000);
            }
        }

        void showAction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("task1 동작");
                Thread.Sleep(1000);
            }
        }

        void showDelegate()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("task2 동작");
                Thread.Sleep(1000);
            }
        }

        void showLamda()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("task3 동작");
                Thread.Sleep(1000);
            }
        }
    }
}

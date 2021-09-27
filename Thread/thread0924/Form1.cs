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

namespace thread0924
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thread 메인(UI)스레드 + 덧붙이는 스레드(워크스레드) 정의
            Thread th_1 = new Thread( () =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine("Work Thread 1");
                    Thread.Sleep(1000);
                }
            });
            // Work Thread 시작
            th_1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("UI Thread");
                Thread.Sleep(1000);
            }
        }
    }
}
           
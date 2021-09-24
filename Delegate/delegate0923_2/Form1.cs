using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate0923_2
{
    delegate int TestDele(int a, int b);
    delegate void TestDele_2();
    delegate void myFunc(int a, int b);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestDele adddele = new TestDele(add);
            Console.WriteLine("덧셈 : {0}", adddele(100, 200));

            // 한 개의 delegate변수에 복수의 메서드를 넣을 수 있음
            TestDele_2 dele = new TestDele_2(print1);
            dele += new TestDele_2(print2);
            dele += new TestDele_2(print3);
            dele();


            // Action -> delegate 와 람다식의 합성을 제공해줌
            // 매개변수가 없고, 실행문이 한 줄인 경우의 기본 람다식
            Action act1 = () => Console.WriteLine("하나의 문장만 실행");
            act1();


            // 하나의 매개변수와 실행문이 한 줄인 람다식( {}를 안 써도 됨)
            int res = 0;
            Action<int> act2 = (x) => res = x + 100;
            act2(100);
            Console.WriteLine($"res : {res}");

            Action<int, int> act3 = (x, y) =>
            {
                int sum = x + y;
                Console.WriteLine($"{sum} = {x} + {y}");
            };

            myFunc testFunct = (num1, num2) =>
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num1}이 {num2}보다 크다");
                }
                else
                {
                    Console.WriteLine($"{num2}이 {num1}보다 크다");
                }
            };
            testFunct(100, 200);
        }

        int add(int a, int b) { return a + b; }

        void print1() { Console.WriteLine("print1"); }

        void print2() { Console.WriteLine("print2"); }

        void print3() { Console.WriteLine("print3"); }
    }
}

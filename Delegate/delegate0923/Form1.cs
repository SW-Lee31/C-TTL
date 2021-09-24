using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegate0923
{   // 대리자
    // 역할1 : 사용자 정의 메시지 전달에 활용
    // 역할2 : 이벤트 핸들러 활용
    // 역할3 : C/C++ 함수 포인터 역할
    // namespace 에서 선언가능
    public delegate void testDelegate(int arg);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // delegate_1가 testMethod()의 역할을 대리로 수행함
            testDelegate delegate_1 = testMethod;
            delegate_1(100);

            // 익명 메서드 사용
            testDelegate delegate_2 = delegate (int b)
            {
                Console.WriteLine($"delegate_2 사용 : {b}");
            };
            delegate_2(200);

            // 람다함수 활용 (최종형 -> 가장 많이 쓰이는 형태)
            testDelegate delegate_3 = (int c) =>
            {
                Console.WriteLine($"delegate_3 사용 : {c}");
            };
            delegate_3(300);
        }

        void testMethod(int a)
        {
            // $를 붙이면 변수를 그대로 사용할 수 있음
            // @는 특수문자를 사용하기 위함 (ex> 경로표시 \\)
            Console.WriteLine($"delgate_1 사용 : {a}");
        }
    }
}

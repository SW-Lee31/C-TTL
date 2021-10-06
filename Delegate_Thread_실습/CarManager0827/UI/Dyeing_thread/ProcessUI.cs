// THREAD_PAUSE를 주석 처리하면 Thread.suspend, resume을 이용한 일시정지 처리
// THREAD_PAUSE를 사용하면 ManualResetEvent -> (Waitone, Set, Reset)을 활용한 일시정지 처리
#define THREAD_PAUSE

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

namespace CarManager0811.UI.Dyeing_thread
{
    public delegate void delMessage(object sender, string str_result);

    public partial class ProcessUI : Form
    {
        public event delMessage eventDelMessage;

#if THREAD_PAUSE
        // true : 신호받음, false : 신호 없음
        ManualResetEvent pauseEvent = new ManualResetEvent(true);
#endif
        string str_work_name;
        Thread thread;
        // 플래그변수 (true, false를 통해 중단, 시행 결정)
        /*bool thread_stop = false;*/

        /*int temp = 0;*/

        public string Str_work_name
        {
            get => str_work_name; set => str_work_name = value;
        }

        public ProcessUI()
        {
            InitializeComponent();
        }

        public ProcessUI(string str)
        {
            InitializeComponent();
            process_lev.Text = Str_work_name = str;
        }

        public void thread_start()
        {
            // thread 객체 생성 시 메서드와 연결(시행메서드)
            thread = new Thread(new ThreadStart(Run));
            // thread.Start()를 통해 연결한 메서드를 시작
            thread.Start();
        }

        public void threadPause()
        {
            // 이벤트 상태를 신호없음(false)으로 설정 -> 스레드 차단
            pauseEvent.Reset();
        }

        public void threadResume()
        {
            // 대기 중인 스레드를 진행토록 이벤트 상태를 신호받음(true)으로 설정
            pauseEvent.Set();
        }

        // 워크 스레드의 작업내용 
        void Run()
        {
            // 스레드, 통신 등은 try_catch를 통해 예외체크를 해줘야 함
            try
            { 
                int ran_value = 0;
                Random r = new Random();
#if THREAD_PAUSE
                // WaitOne() -> Invoke 안 써도 됨?
                while(pauseEvent.WaitOne())
#else
                while (process_progress.Value < 100 && !thread_stop)
#endif
                {
                    // 워크스레드에서 UI스레드로 접근 가능한 지 체크
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() =>
                        {
                            ran_value = r.Next(1, 11);
                            if (process_progress.Value + ran_value > 100)
                            {
                                process_progress.Value = 100;
                                Thread.Sleep(500);
#if THREAD_PAUSE
                                eventDelMessage(this, "작업 완료");
#endif
                            }
                            else
                            {
                                process_progress.Value += ran_value;
                            }
                            process_per.Text = string.Format("진행 상황 : {0}%", process_progress.Value);
                        }));
                        Thread.Sleep(200);
                    }
                }

#if !THREAD_PAUSE
                if (thread_stop == false)
                {   
                    eventDelMessage(this, "작업 완료");
                    this.Invoke(new Action(() =>
                    {
                        Close();
                        thread_abort();
                    }));
                }
#endif
            }
            // thread관련 오류
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("인터럽트 오류 : " + e.Message);
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("알 수 없는 오류 : " + e.Message);
            }
        }

        public void thread_abort()
        {
            // thread가 살아있는 지 여부
            if (thread.IsAlive)
            {
                // 스레드 일시정지
                thread.Abort();
                // 스레드 안전하게 제거
                thread.Join();
            }
        }

        public void thread_interrupt()
        {
            if (thread.IsAlive)
            {
                // 스레드에 인터럽트 발생
                thread.Interrupt();
            }
        }

        private void but_stop_Click(object sender, EventArgs e)
        {
#if !THREAD_PAUSE
            if (but_stop.Text == "작업 중지")
            {
                if (thread.IsAlive)
                {
                    eventDelMessage(this, "작업 중지");
                    thread.Suspend();
                    but_stop.Text = "작업 재개";
                    thread_stop = true;
                    
                }
            }
            else if (but_stop.Text == "작업 재개")
            {
                eventDelMessage(this, "작업 재개");
                but_stop.Text = "작업 중지";
                thread_stop = false;
                thread.Resume();
                
            }
#else
            if (but_stop.Text == "작업 중지")
            {
                but_stop.Text = "작업 재개";
                process_con.Text = "공정이 중지 되었습니다.";
                eventDelMessage(this, "작업 중지");
            }
            else if (but_stop.Text.Equals("작업 재개"))
            {
                but_stop.Text = "작업 중지";
                process_con.Text = "공정이 진행 중입니다.";
                eventDelMessage(this, "작업 재개");
            }
#endif
        }
    }
}

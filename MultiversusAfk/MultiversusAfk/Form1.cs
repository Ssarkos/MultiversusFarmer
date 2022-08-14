using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;


namespace MultiversusAfk
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, int lParam);


        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x0101;
        const UInt32 WM_CHAR = 0x0102;

        IntPtr V = (IntPtr)0x56;
        IntPtr W = (IntPtr)0x57;
        IntPtr A = (IntPtr)0x41;
        IntPtr S = (IntPtr)0x53;
        IntPtr D = (IntPtr)0x44;
        IntPtr O = (IntPtr)0x4F;
        IntPtr T = (IntPtr)0x54;
        IntPtr P = (IntPtr)0x50;
        IntPtr Space = (IntPtr)0x20;
        IntPtr VKEnter = (IntPtr)0x0D;

        bool running = false;
        ThreadStart run;
        Thread farming;
        ThreadStart time;
        Thread updateTimer;
        int gamesPlayed = 0;
        int stepsX = 0;
        int stepsY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!running)
            {                
                running = true;
                run = new ThreadStart(farm);
                farming = new Thread(run);
                farming.Start();

                farmMenu();
            }
        }

        private void idleMenu()
        {
            btnStart.Show();
            btnChar.Show();
            lblChar.Show();

            btnStop.Hide();
            lblGames.Hide();
            lblTime.Hide();
        }

        private void farmMenu()
        {
            btnStart.Hide();
            btnChar.Hide();
            lblChar.Hide();

            btnStop.Show();
            lblGames.Show();
            lblTime.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            running = false;
            farming.Abort();
            updateTimer.Abort();
            gamesPlayed = 0;

            idleMenu();
        }

        private void timer()
        {
            DateTime start = DateTime.Now;
            while (true)
            {
                TimeSpan time = TimeSpan.FromSeconds((DateTime.Now - start).TotalSeconds);
                lblTime.Text = time.ToString(@"hh\:mm\:ss");
                Thread.Sleep(50);
            }
        }

        private void farm()
        {
            IntPtr hwnd = FindWindow(null, "MultiVersus  ");

            if (hwnd == IntPtr.Zero)
            {
                MessageBox.Show("MultiVersus is not running.", "Error");
                running = false;
                idleMenu();

                return;
            }

            time = new ThreadStart(timer);
            updateTimer = new Thread(time);
            updateTimer.Start();

            while (true)
            {
                //for (int j = 0; j < 2; j++)
                //{
                    lblGames.Text = "Matches Played: " + gamesPlayed;                   

                    Thread.Sleep(1000);
                    for (int i = 0; i < 17; i++)
                    {
                        presskey(S, hwnd);
                        presskey(D, hwnd);
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < stepsX; i++)
                    {
                        presskey(A, hwnd);
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < stepsY; i++)
                    {
                        presskey(W, hwnd);
                        Thread.Sleep(30);
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        presskey(Space, hwnd);
                    }
                    Thread.Sleep(300);
                    for (int i = 0; i < 4; i++)
                    {
                        presskey(V, hwnd);
  
                    }

                    /*if (j == 0)
                    {
                        Thread.Sleep(17000);
                    }
                    else
                    {
                        Thread.Sleep(10000);
                    }*/

                    Thread.Sleep(16000);

                    for (int i = 0; i < 20; i++)
                    {
                        presskey(V, hwnd);
                        Thread.Sleep(100);
                    }

                    Thread.Sleep(31000);

                    for (int i = 0; i < 7; i++)
                    {
                        presskey(O, hwnd);
                        presskey(P, hwnd);
                        Thread.Sleep(500);
                        presskey(P, hwnd);
                        Thread.Sleep(900);
                    }

                    for (int i = 0; i < 55; i++)
                    {
                        PostMessage(hwnd, WM_KEYDOWN, A, 0);
                        presskey(P, hwnd);
                        Thread.Sleep(500);
                    }
                    PostMessage(hwnd, WM_KEYUP, A, 0);

                    Thread.Sleep(12000);

                    for (int i = 0; i < 30; i++)
                    {
                        presskey(V, hwnd);
                        presskey(Space, hwnd);
                        Thread.Sleep(100);
                    }

                    Thread.Sleep(5000);

                    gamesPlayed++;
                //}
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void presskey(IntPtr key, IntPtr hwnd)
        {
            PostMessage(hwnd, WM_KEYDOWN, key, 0);
            Thread.Sleep(10);
            PostMessage(hwnd, WM_KEYUP, key, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idleMenu();
        }

        private void btnChar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((string)btnChar.SelectedItem == "Shaggy")
            {
                stepsX = 8;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Batman")
            {
                stepsX = 7;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Taz")
            {
                stepsX = 6;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Garnet")
            {
                stepsX = 5;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Jake")
            {
                stepsX = 4;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Finn")
            {
                stepsX = 3;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Arya Stark")
            {
                stepsX = 2;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Harley Quinn")
            {
                stepsX = 1;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Lebron James")
            {
                stepsX = 0;
                stepsY = 1;
            }
            else if ((string)btnChar.SelectedItem == "Wonder Woman")
            {
                stepsX = 8;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Superman")
            {
                stepsX = 7;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Iron Giant")
            {
                stepsX = 6;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Steven Universe")
            {
                stepsX = 5;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Reindog")
            {
                stepsX = 4;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Velma")
            {
                stepsX = 3;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Bugs Bunny")
            {
                stepsX = 2;
                stepsY = 0;
            }
            else if ((string)btnChar.SelectedItem == "Tom & Jerry")
            {
                stepsX = 1;
                stepsY = 0;
            }
            else
            {
                stepsX = 0;
                stepsY = 0;
            }
        }
    }
}

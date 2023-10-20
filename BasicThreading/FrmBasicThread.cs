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


namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Thread ThreadA, ThreadB;
            ThreadStart StartThread = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(StartThread);
            ThreadB = new Thread(StartThread);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            Console.WriteLine(label1.Text.ToString());

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            label1.Text = "-End Of Thread";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
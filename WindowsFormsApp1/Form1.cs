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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            Thread threadA = new Thread(thread);
            Thread threadB = new Thread(thread);

            threadA.Name = "ThreadA process:";
            threadB.Name = "ThreadB process:";

            Console.WriteLine(label1.Text.ToString());

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();
            label1.Text = "End of a Thread";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}

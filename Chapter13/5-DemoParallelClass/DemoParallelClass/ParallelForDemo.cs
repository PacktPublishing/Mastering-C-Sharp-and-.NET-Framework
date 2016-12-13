using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoParallelClass
{
    public partial class ParallelForDemo : Form
    {
        Stopwatch watch = new Stopwatch();
        string cr = Environment.NewLine;
        SynchronizationContext context;
        public ParallelForDemo()
        {
            InitializeComponent();
            //context = new SynchronizationContext();
            context = SynchronizationContext.Current;
        }

        private void btnStandardFor_Click(object sender, EventArgs e)
        {
            rtbOutput.ResetText();
            watch.Start();
            for (int i = 1; i < 1000; i++)
            {
                if (i.IsPrime())
                    rtbOutput.Text += string.Format("{0} is prime", i) + cr;
                else
                    rtbOutput.Text += string.Format("{0} is NOT prime", i) + cr;
            }
            watch.Stop();
            label1.Text = "Elapsed Time: " +
                watch.ElapsedMilliseconds.ToString("0,000") + " ms."; ;
        }

        private void btnParallelFor_Click(object sender, EventArgs e)
        {
            rtbOutput.ResetText();
            watch.Restart();
            Parallel.For(1, 1000, (i) =>
            {
                if (i.IsPrime())
                    context.Post(new SendOrPostCallback((x) =>
                    {
                        UpdateUI(string.Format("{0} is prime", i));
                    }), null);
                else
                    context.Post(new SendOrPostCallback((x) =>
                    {
                        UpdateUI(string.Format("{0} is NOT prime", i));
                    }), null);
            });
            watch.Stop();
            label2.Text = "Elapsed Time: " +
                watch.ElapsedMilliseconds.ToString("0,000") + " ms.";
        }
        private void UpdateUI(string data)
        {
            this.Invoke(new Action(() =>
            {
                rtbOutput.Text += data + cr;
            }));
        }
    }
}

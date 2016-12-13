using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace DEMOLINQ1
{
    public partial class Form1 : Form
    {
        Stopwatch watch = new Stopwatch();
        IEnumerable<int> numbers = Enumerable.Range(1, 5000000);
        string strLabel = "Time Elapsed: ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePrimes_Click(object sender, EventArgs e)
        {
            watch.Restart();
            var query = numbers.Where(n => n.IsPrime());
            var primes = query.ToList();
            watch.Stop();
            label1.Text = strLabel + watch.ElapsedMilliseconds.ToString("0,000")+ " ms.";
            // most of time is spent loading data into the listbox
            listBox1.DataSource = primes.ToList();
        }

        private void btnGenParallel_Click(object sender, EventArgs e)
        {
            watch.Restart();
            var query = numbers.AsParallel().Where(n => n.IsPrime());
            var primes = query.ToList();
            watch.Stop();
            lblParallel.Text = strLabel + watch.ElapsedMilliseconds.ToString("0,000") + " ms.";
            listBox2.DataSource = primes.ToList();

        }
        private void btnGenParallelOrdered_Click(object sender, EventArgs e)
        {
            watch.Restart();
            var query = numbers.AsParallel().AsOrdered().Where(n => n.IsPrime());
            var primes = query.ToList();
            watch.Stop();
            lblParallelOrdered.Text = strLabel + watch.ElapsedMilliseconds.ToString("0,000") + " ms.";
            listBox3.DataSource = primes.ToList();
        }

        private void btnGenParWithDegree_Click(object sender, EventArgs e)
        {
            watch.Restart();
            var query = numbers.AsParallel().AsOrdered()
                .WithDegreeOfParallelism(Environment.ProcessorCount/2)
                .Where(n => n.IsPrime());
            var primes = query.ToList();
            watch.Stop();
            lblParWithDegree.Text = strLabel + watch.ElapsedMilliseconds.ToString("0,000") + " ms.";
            listBox4.DataSource = primes.ToList();
        }

        private void btnPrimesWithCancel_Click(object sender, EventArgs e)
        {
            List<int> primes;
            using (var cs = new CancellationTokenSource())
            {
                watch.Restart();
                var query = numbers.AsParallel().AsOrdered()
                    .WithCancellation(cs.Token)
                    .WithDegreeOfParallelism(Environment.ProcessorCount / 2)
                    .Where(n => n.IsPrime(cs));
                try
                {
                    primes = query.ToList();
                }
                catch (OperationCanceledException oc)
                {
                    string msg1 = "Query cancelled.";
                    string msg2 = "Cancel Requested: " +
                        oc.CancellationToken.IsCancellationRequested.ToString();
                    listBox5.Items.Add(msg1);
                    listBox5.Items.Add(msg2);
                }
            }
            watch.Stop();
            lblCancel.Text = strLabel +
                watch.ElapsedMilliseconds.ToString("0,000") + " ms.";
        }
    }
}

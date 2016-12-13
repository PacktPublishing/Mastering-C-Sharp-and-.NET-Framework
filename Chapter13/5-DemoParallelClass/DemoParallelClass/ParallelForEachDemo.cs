using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoParallelClass
{
    public partial class ParallelForEachDemo : Form
    {
        public ParallelForEachDemo()
        {
            InitializeComponent();

        }
        Stopwatch watch = new Stopwatch();
        string[] files = Directory.GetFiles(@"D:\MEDIA\CLIPART\Graficos\ICONOS\Angular\128x128", "*.png");
        string modDir = @"D:\MEDIA\CLIPART\Graficos\ICONOS\Angular\128x128\Modified";
        public void ProcessImages()
        {
            Directory.CreateDirectory(modDir);
            watch.Start();
            foreach (var file in files)
            {
                string filename = Path.GetFileName(file);
                var bitmap = new Bitmap(file);
                bitmap.MakeTransparent(Color.White);
                bitmap.Save(Path.Combine(modDir, filename));
            }
            watch.Stop();
            lblForEachStandard.Text += watch.ElapsedMilliseconds.ToString() + " ms.";
            watch.Restart();
            Parallel.ForEach(files, (file) =>
            {
                string filename = Path.GetFileName(file);
                var bitmap = new Bitmap(file);
                bitmap.MakeTransparent(Color.White);
                bitmap.Save(Path.Combine(modDir, "T_" + filename));
                //Console.WriteLine("Processing {0} on thread {1}", filename, 
                //    Thread.CurrentThread.ManagedThreadId);
            });
            watch.Stop();
            lblParallel.Text += watch.ElapsedMilliseconds.ToString() + " ms.";
            MessageBox.Show("Finished");
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            ProcessImages();
        }
    }
}

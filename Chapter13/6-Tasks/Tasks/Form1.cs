using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Form1 : Form
    {
        string filesPath = @"[PUT_THE_PATH_TO_A_FOLDER_WITH_GRAPHICS_HERE]";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var getFiles = new Task<List<string>>(() => getListOfIconsAsync());
            getFiles.Start();
            getFiles.ContinueWith((f) => UpdateUI(getFiles.Result),
                 TaskScheduler.FromCurrentSynchronizationContext());
        }
        private List<string> getListOfIconsAsync()
        {
            string[] files = Directory.GetFiles(filesPath, "*.png");
            return files.ToList();
        }
        private void UpdateUI(List<string> filenames)
        {
            listBox1.Items.Clear();
            listBox1.DataSource = filenames;
        }
    }
}
//               

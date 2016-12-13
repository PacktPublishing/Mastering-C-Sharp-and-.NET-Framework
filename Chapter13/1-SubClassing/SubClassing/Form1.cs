using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubClassing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            // Captures messages relative to left mouse button
            if (m.Msg >= 513 && m.Msg <= 515)
            {
                MessageBox.Show("Processing message: " + m.Msg);
            }
            base.WndProc(ref m);
        }
    }
}

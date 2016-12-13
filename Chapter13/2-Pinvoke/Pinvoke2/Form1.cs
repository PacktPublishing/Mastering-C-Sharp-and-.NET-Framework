using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pinvoke2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, 
            int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, 
            IntPtr wParam, IntPtr lParam);
        IntPtr calcHandler;
        private const UInt32 WM_CLOSE = 0x0010;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            calcHandler =  FindWindowByCaption(IntPtr.Zero, "Calculator");
            SetWindowPos(calcHandler, 0, 0, 0, 0, 0, 0x0001 | 0x0040);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SendMessage(calcHandler, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Interop1
{
    public partial class fmInteropExcel : Form
    {

        public Excel.Application excel = new Excel.Application();
        public fmInteropExcel()
        {
            InitializeComponent();
            excel.Visible = true;
            excel.Workbooks.Add();

        }
        private void btnOpenExcel_Click(object sender, EventArgs e)
        {
            OpenExcel();
        }
        public void OpenExcel()
        {
            var oSheet = excel.Sheets[1]; // Index starts by 1

            excel.get_Range("A1").Value2 = "Initial Data";
            excel.get_Range("A2").Value2 = "Demo data 1";
            excel.get_Range("A3").Value2 = "Demo data 2";
            excel.get_Range("A4").Value2 = "Demo data 3";

            // An alternative way to get a range object
            var oRange = (Excel.Range)oSheet.Range[oSheet.Cells[1, 2],
                            oSheet.Cells[4, 3]];
            oRange.Value2 = "Same value";
            oRange.Style = FormatCells();
            oRange.Columns.AutoFit();

            // Load an image to Clipboard and paste it
            // CopyToClipboard();
            // Get an image from a Website
            // Clipboard.SetImage(LoadImageFromSite());
        }

        public Excel.Style FormatCells()
        {
            Excel.Style style = excel.ActiveWorkbook.Styles.Add("myStyle");
            //Creation of an style to format the cells
            style.Font.Name = "Segoe UI";
            style.Font.Size = 14;
            style.Font.Color = ColorTranslator.ToOle(Color.White);
            style.Interior.Color = ColorTranslator.ToOle(Color.Silver);
            style.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            return style;
        }
        public void CopyToClipboard()
        {
            Clipboard.SetImage(new Bitmap("Packt.jpg"));
        }

        public Bitmap LoadImageFromSite()
        {
            // Change your URL to point to any other image... 
            var urlImg = @"https://www.packtpub.com/sites/default/files/B05245_MockupCover_Normal_.jpg";
            WebRequest request = WebRequest.Create(urlImg);
            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            return new Bitmap(responseStream);
        }
        public void DrawChart()
        {
            var processes = Process.GetProcesses()
                                    .OrderBy(p => p.WorkingSet64);
            int i = 2;
            foreach (var p in processes)
            {
                if (p.ProcessName == "WINWORD" ||
                    p.ProcessName == "OUTLOOK" ||
                    p.ProcessName == "EXCEL")
                {
                    excel.get_Range("A" + i).Value2 = p.ProcessName;
                    excel.get_Range("B" + i).Value2 = p.WorkingSet64;
                    i++;
                }
            }

            Excel.Range range = excel.get_Range("A1");
            Excel.Chart chart = (Excel.Chart)excel.ActiveWorkbook.Charts.Add(
                After: excel.ActiveSheet);

            chart.ChartWizard(Source: range.CurrentRegion,
                Title: "Memory Usage of Office Applications");
            chart.ChartType = Excel.XlChartType.xl3DArea;
            chart.ChartStyle = 14;
            chart.ChartArea.Copy();
        }
        private void btnGenerateGraph_Click(object sender, EventArgs e)
        {
            DrawChart();
            if (Clipboard.ContainsImage())
            {
                pbChart.SizeMode = PictureBoxSizeMode.StretchImage;
                pbChart.Image = Clipboard.GetImage();
            }
            else
            {
                MessageBox.Show("Clipboard is empty");
            }
        }

        private void frmInteropExcel_FormClosing(object sender, FormClosingEventArgs e)
        {
            excel.ActiveWorkbook.Saved = true;
            excel.UserControl = false;
            excel.Quit();
        }
    }
}

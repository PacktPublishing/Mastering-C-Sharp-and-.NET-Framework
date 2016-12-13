using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WMIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQueryOS_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            // First, we get some information about the Operating System:
            // Name, Version, Manufacturer, Computer Name, and Windows Directory
            // We call Get() to retrieve the collection of objects and loop through it
            var osSearch = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            listBox1.Items.Add("Operating System Info");
            listBox1.Items.Add("-----------------------------");
            foreach (ManagementObject osInfo in osSearch.Get())
            {
                listBox1.Items.Add("Name: " + osInfo["name"].ToString());
                listBox1.Items.Add("Version: " + osInfo["version"].ToString());
                listBox1.Items.Add("Manufacturer: " + osInfo["manufacturer"].ToString());
                listBox1.Items.Add("Computer name: " + osInfo["csname"].ToString());
                listBox1.Items.Add("Windows Directory: " + osInfo["windowsdirectory"].ToString());
            }

            // Now, some data about the processor and BIOS
            listBox2.Items.Add("Processor Info");
            listBox2.Items.Add("------------------");
            var ProcQuery = new SelectQuery("Win32_processor");
            ManagementObjectSearcher ProcSearch = new ManagementObjectSearcher(ProcQuery);
            foreach (ManagementObject ProcInfo in ProcSearch.Get())
            {
                listBox2.Items.Add("Processor: " + ProcInfo["caption"].ToString());
            }

            listBox2.Items.Add("BIOS Info");
            listBox2.Items.Add("-------------");
            var BiosQuery = new SelectQuery("Win32_bios");
            ManagementObjectSearcher BiosSearch = new ManagementObjectSearcher(BiosQuery);
            foreach (ManagementObject BiosInfo in BiosSearch.Get())
            {
                listBox2.Items.Add("Bios: " + BiosInfo["version"].ToString());
            }

            // An enumeration of Win32_Environment instances
            listBox2.Items.Add("Environment Instances");
            listBox2.Items.Add("-----------------------------");
            var envQuery = new SelectQuery("Win32_Environment");
            ManagementObjectSearcher envInstances = new ManagementObjectSearcher(envQuery);
            foreach (ManagementBaseObject envVar in envInstances.Get())
                listBox2.Items.Add(envVar["Name"] + " -- " + envVar["VariableValue"]);

            // Finally, a list of shared units
            listBox2.Items.Add("Shared Units");
            listBox2.Items.Add("------------------");
            var sharedQuery = new ManagementObjectSearcher("select * from win32_share");
            foreach (ManagementObject share in sharedQuery.Get())
            {
                listBox2.Items.Add("Share = " + share["Name"]);
            }
        }

        private void btnQueryTables_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ManagementObjectSearcher mos = new ManagementObjectSearcher
                ("SELECT * FROM meta_class WHERE __CLASS LIKE 'Win32_%'");
            foreach (ManagementObject obj in mos.Get())
                listBox1.Items.Add(obj["__CLASS"]);
            listBox1.Sorted = true;
        }

        private void btnQueryService_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var mo = new ManagementObject(@"Win32_service='LSM'");
            foreach (var o in mo.GetRelated("Win32_Service", "Win32_DependentService",
                null, null, "Antecedent", "Dependent", false, null))
            {
                listBox1.Items.Add(o["__PATH"]);
            }
        }

        private void btnDiskQuota_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ManagementObject disk = new
                    ManagementObject("win32_logicaldisk.deviceid='c:'");
            disk.Get();
            var totalMb = long.Parse(disk["Size"].ToString()) / (1024 * 1024);
            var freeMb = long.Parse(disk["FreeSpace"].ToString()) / (1024 * 1024);
            listBox1.Items.Add("Logical Disk Size = " + totalMb + " Mb.");
            listBox1.Items.Add("Logical Disk FreeSpace = " + freeMb + " Mb.");

        }
    }
}

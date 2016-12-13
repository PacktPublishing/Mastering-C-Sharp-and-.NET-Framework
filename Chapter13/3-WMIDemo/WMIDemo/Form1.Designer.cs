namespace WMIDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnQueryOS = new System.Windows.Forms.Button();
            this.btnQueryTables = new System.Windows.Forms.Button();
            this.btnQueryService = new System.Windows.Forms.Button();
            this.btnDiskQuota = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(231, 47);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(472, 418);
            this.listBox1.TabIndex = 0;
            // 
            // btnQueryOS
            // 
            this.btnQueryOS.Location = new System.Drawing.Point(33, 160);
            this.btnQueryOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryOS.Name = "btnQueryOS";
            this.btnQueryOS.Size = new System.Drawing.Size(181, 79);
            this.btnQueryOS.TabIndex = 1;
            this.btnQueryOS.Text = "Query Win32_OperatingSystem";
            this.btnQueryOS.UseVisualStyleBackColor = true;
            this.btnQueryOS.Click += new System.EventHandler(this.btnQueryOS_Click);
            // 
            // btnQueryTables
            // 
            this.btnQueryTables.Location = new System.Drawing.Point(33, 47);
            this.btnQueryTables.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryTables.Name = "btnQueryTables";
            this.btnQueryTables.Size = new System.Drawing.Size(181, 79);
            this.btnQueryTables.TabIndex = 2;
            this.btnQueryTables.Text = "Query Tables";
            this.btnQueryTables.UseVisualStyleBackColor = true;
            this.btnQueryTables.Click += new System.EventHandler(this.btnQueryTables_Click);
            // 
            // btnQueryService
            // 
            this.btnQueryService.Location = new System.Drawing.Point(33, 273);
            this.btnQueryService.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryService.Name = "btnQueryService";
            this.btnQueryService.Size = new System.Drawing.Size(181, 79);
            this.btnQueryService.TabIndex = 3;
            this.btnQueryService.Text = "Query Service";
            this.btnQueryService.UseVisualStyleBackColor = true;
            this.btnQueryService.Click += new System.EventHandler(this.btnQueryService_Click);
            // 
            // btnDiskQuota
            // 
            this.btnDiskQuota.Location = new System.Drawing.Point(33, 386);
            this.btnDiskQuota.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiskQuota.Name = "btnDiskQuota";
            this.btnDiskQuota.Size = new System.Drawing.Size(181, 79);
            this.btnDiskQuota.TabIndex = 4;
            this.btnDiskQuota.Text = "Query Dislk";
            this.btnDiskQuota.UseVisualStyleBackColor = true;
            this.btnDiskQuota.Click += new System.EventHandler(this.btnDiskQuota_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(711, 47);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 418);
            this.listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 486);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnDiskQuota);
            this.Controls.Add(this.btnQueryService);
            this.Controls.Add(this.btnQueryTables);
            this.Controls.Add(this.btnQueryOS);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "WMI Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnQueryOS;
        private System.Windows.Forms.Button btnQueryTables;
        private System.Windows.Forms.Button btnQueryService;
        private System.Windows.Forms.Button btnDiskQuota;
        private System.Windows.Forms.ListBox listBox2;
    }
}


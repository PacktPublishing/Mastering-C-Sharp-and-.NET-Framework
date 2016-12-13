namespace DEMOLINQ1
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
            this.btnGeneratePrimes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParallel = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnGenParallel = new System.Windows.Forms.Button();
            this.lblParallelOrdered = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnGenParallelOrdered = new System.Windows.Forms.Button();
            this.lblParWithDegree = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.btnGenParWithDegree = new System.Windows.Forms.Button();
            this.lblCancel = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.btnPrimesWithCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneratePrimes
            // 
            this.btnGeneratePrimes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePrimes.Location = new System.Drawing.Point(30, 30);
            this.btnGeneratePrimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeneratePrimes.Name = "btnGeneratePrimes";
            this.btnGeneratePrimes.Size = new System.Drawing.Size(185, 51);
            this.btnGeneratePrimes.TabIndex = 0;
            this.btnGeneratePrimes.Text = "Gen. Primes (Sync)";
            this.btnGeneratePrimes.UseVisualStyleBackColor = true;
            this.btnGeneratePrimes.Click += new System.EventHandler(this.btnGeneratePrimes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(30, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 293);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Elapsed: ";
            // 
            // lblParallel
            // 
            this.lblParallel.AutoSize = true;
            this.lblParallel.Location = new System.Drawing.Point(231, 89);
            this.lblParallel.Name = "lblParallel";
            this.lblParallel.Size = new System.Drawing.Size(105, 19);
            this.lblParallel.TabIndex = 5;
            this.lblParallel.Text = "Time Elapsed: ";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(231, 125);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(185, 293);
            this.listBox2.TabIndex = 4;
            // 
            // btnGenParallel
            // 
            this.btnGenParallel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenParallel.Location = new System.Drawing.Point(231, 30);
            this.btnGenParallel.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenParallel.Name = "btnGenParallel";
            this.btnGenParallel.Size = new System.Drawing.Size(185, 51);
            this.btnGenParallel.TabIndex = 3;
            this.btnGenParallel.Text = "Gen. Primes (Parallel)";
            this.btnGenParallel.UseVisualStyleBackColor = true;
            this.btnGenParallel.Click += new System.EventHandler(this.btnGenParallel_Click);
            // 
            // lblParallelOrdered
            // 
            this.lblParallelOrdered.AutoSize = true;
            this.lblParallelOrdered.Location = new System.Drawing.Point(434, 89);
            this.lblParallelOrdered.Name = "lblParallelOrdered";
            this.lblParallelOrdered.Size = new System.Drawing.Size(105, 19);
            this.lblParallelOrdered.TabIndex = 8;
            this.lblParallelOrdered.Text = "Time Elapsed: ";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Location = new System.Drawing.Point(434, 125);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(241, 293);
            this.listBox3.TabIndex = 7;
            // 
            // btnGenParallelOrdered
            // 
            this.btnGenParallelOrdered.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenParallelOrdered.Location = new System.Drawing.Point(434, 30);
            this.btnGenParallelOrdered.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenParallelOrdered.Name = "btnGenParallelOrdered";
            this.btnGenParallelOrdered.Size = new System.Drawing.Size(241, 51);
            this.btnGenParallelOrdered.TabIndex = 6;
            this.btnGenParallelOrdered.Text = "Gen. Primes (Parallel/Ordered)";
            this.btnGenParallelOrdered.UseVisualStyleBackColor = true;
            this.btnGenParallelOrdered.Click += new System.EventHandler(this.btnGenParallelOrdered_Click);
            // 
            // lblParWithDegree
            // 
            this.lblParWithDegree.AutoSize = true;
            this.lblParWithDegree.Location = new System.Drawing.Point(692, 89);
            this.lblParWithDegree.Name = "lblParWithDegree";
            this.lblParWithDegree.Size = new System.Drawing.Size(105, 19);
            this.lblParWithDegree.TabIndex = 11;
            this.lblParWithDegree.Text = "Time Elapsed: ";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 17;
            this.listBox4.Location = new System.Drawing.Point(692, 125);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(185, 293);
            this.listBox4.TabIndex = 10;
            // 
            // btnGenParWithDegree
            // 
            this.btnGenParWithDegree.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenParWithDegree.Location = new System.Drawing.Point(692, 13);
            this.btnGenParWithDegree.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenParWithDegree.Name = "btnGenParWithDegree";
            this.btnGenParWithDegree.Size = new System.Drawing.Size(185, 68);
            this.btnGenParWithDegree.TabIndex = 9;
            this.btnGenParWithDegree.Text = "Gen. Primes (Parallel) with Degree";
            this.btnGenParWithDegree.UseVisualStyleBackColor = true;
            this.btnGenParWithDegree.Click += new System.EventHandler(this.btnGenParWithDegree_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(902, 89);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(105, 19);
            this.lblCancel.TabIndex = 14;
            this.lblCancel.Text = "Time Elapsed: ";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 17;
            this.listBox5.Location = new System.Drawing.Point(902, 125);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(185, 293);
            this.listBox5.TabIndex = 13;
            // 
            // btnPrimesWithCancel
            // 
            this.btnPrimesWithCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimesWithCancel.Location = new System.Drawing.Point(902, 30);
            this.btnPrimesWithCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimesWithCancel.Name = "btnPrimesWithCancel";
            this.btnPrimesWithCancel.Size = new System.Drawing.Size(185, 51);
            this.btnPrimesWithCancel.TabIndex = 12;
            this.btnPrimesWithCancel.Text = "Gen. Primes (Parallel, with Cancel)";
            this.btnPrimesWithCancel.UseVisualStyleBackColor = true;
            this.btnPrimesWithCancel.Click += new System.EventHandler(this.btnPrimesWithCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 481);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.btnPrimesWithCancel);
            this.Controls.Add(this.lblParWithDegree);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.btnGenParWithDegree);
            this.Controls.Add(this.lblParallelOrdered);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.btnGenParallelOrdered);
            this.Controls.Add(this.lblParallel);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnGenParallel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGeneratePrimes);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratePrimes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParallel;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnGenParallel;
        private System.Windows.Forms.Label lblParallelOrdered;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnGenParallelOrdered;
        private System.Windows.Forms.Label lblParWithDegree;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button btnGenParWithDegree;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button btnPrimesWithCancel;
    }
}


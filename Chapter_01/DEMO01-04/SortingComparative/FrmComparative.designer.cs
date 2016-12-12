namespace SortingComparative
{
    partial class FrmComparative
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
            this.components = new System.ComponentModel.Container();
            this.lbBubble = new System.Windows.Forms.ListBox();
            this.lbHeap = new System.Windows.Forms.ListBox();
            this.lbMerge = new System.Windows.Forms.ListBox();
            this.lbInternal = new System.Windows.Forms.ListBox();
            this.lbETBublle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.lbETInternal = new System.Windows.Forms.Label();
            this.lbETMerge = new System.Windows.Forms.Label();
            this.lbETHeap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnHeap = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnInternal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGenerateNum = new System.Windows.Forms.Button();
            this.nudTotalNumbers = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBubble
            // 
            this.lbBubble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBubble.FormattingEnabled = true;
            this.lbBubble.ItemHeight = 19;
            this.lbBubble.Location = new System.Drawing.Point(33, 50);
            this.lbBubble.Name = "lbBubble";
            this.lbBubble.Size = new System.Drawing.Size(148, 232);
            this.lbBubble.TabIndex = 0;
            // 
            // lbHeap
            // 
            this.lbHeap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeap.FormattingEnabled = true;
            this.lbHeap.ItemHeight = 19;
            this.lbHeap.Location = new System.Drawing.Point(230, 50);
            this.lbHeap.Name = "lbHeap";
            this.lbHeap.Size = new System.Drawing.Size(148, 232);
            this.lbHeap.TabIndex = 3;
            // 
            // lbMerge
            // 
            this.lbMerge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMerge.FormattingEnabled = true;
            this.lbMerge.ItemHeight = 19;
            this.lbMerge.Location = new System.Drawing.Point(427, 50);
            this.lbMerge.Name = "lbMerge";
            this.lbMerge.Size = new System.Drawing.Size(148, 232);
            this.lbMerge.TabIndex = 4;
            // 
            // lbInternal
            // 
            this.lbInternal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInternal.FormattingEnabled = true;
            this.lbInternal.ItemHeight = 19;
            this.lbInternal.Location = new System.Drawing.Point(624, 50);
            this.lbInternal.Name = "lbInternal";
            this.lbInternal.Size = new System.Drawing.Size(148, 232);
            this.lbInternal.TabIndex = 5;
            // 
            // lbETBublle
            // 
            this.lbETBublle.AutoSize = true;
            this.lbETBublle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETBublle.Location = new System.Drawing.Point(29, 318);
            this.lbETBublle.Name = "lbETBublle";
            this.lbETBublle.Size = new System.Drawing.Size(66, 19);
            this.lbETBublle.TabIndex = 6;
            this.lbETBublle.Text = "Seconds:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Elapsed Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Elapsed Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Elapsed Time:";
            // 
            // btnBubble
            // 
            this.btnBubble.AutoSize = true;
            this.btnBubble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.Location = new System.Drawing.Point(33, 353);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(148, 29);
            this.btnBubble.TabIndex = 11;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // lbETInternal
            // 
            this.lbETInternal.AutoSize = true;
            this.lbETInternal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETInternal.Location = new System.Drawing.Point(629, 320);
            this.lbETInternal.Name = "lbETInternal";
            this.lbETInternal.Size = new System.Drawing.Size(66, 19);
            this.lbETInternal.TabIndex = 16;
            this.lbETInternal.Text = "Seconds:";
            // 
            // lbETMerge
            // 
            this.lbETMerge.AutoSize = true;
            this.lbETMerge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETMerge.Location = new System.Drawing.Point(429, 320);
            this.lbETMerge.Name = "lbETMerge";
            this.lbETMerge.Size = new System.Drawing.Size(66, 19);
            this.lbETMerge.TabIndex = 15;
            this.lbETMerge.Text = "Seconds:";
            // 
            // lbETHeap
            // 
            this.lbETHeap.AutoSize = true;
            this.lbETHeap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETHeap.Location = new System.Drawing.Point(229, 320);
            this.lbETHeap.Name = "lbETHeap";
            this.lbETHeap.Size = new System.Drawing.Size(66, 19);
            this.lbETHeap.TabIndex = 14;
            this.lbETHeap.Text = "Seconds:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Elapsed Time:";
            // 
            // btnHeap
            // 
            this.btnHeap.AutoSize = true;
            this.btnHeap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeap.Location = new System.Drawing.Point(230, 353);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(148, 29);
            this.btnHeap.TabIndex = 18;
            this.btnHeap.Text = "Heap";
            this.btnHeap.UseVisualStyleBackColor = true;
            this.btnHeap.Click += new System.EventHandler(this.btnHeap_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.AutoSize = true;
            this.btnMerge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(427, 353);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(150, 29);
            this.btnMerge.TabIndex = 19;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnInternal
            // 
            this.btnInternal.AutoSize = true;
            this.btnInternal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternal.Location = new System.Drawing.Point(626, 353);
            this.btnInternal.Name = "btnInternal";
            this.btnInternal.Size = new System.Drawing.Size(148, 29);
            this.btnInternal.TabIndex = 20;
            this.btnInternal.Text = "Internal";
            this.btnInternal.UseVisualStyleBackColor = true;
            this.btnInternal.Click += new System.EventHandler(this.btnInternal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerateNum);
            this.groupBox1.Controls.Add(this.nudTotalNumbers);
            this.groupBox1.Location = new System.Drawing.Point(23, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 71);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generation Mechanism";
            // 
            // btnGenerateNum
            // 
            this.btnGenerateNum.AutoSize = true;
            this.btnGenerateNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNum.Location = new System.Drawing.Point(169, 29);
            this.btnGenerateNum.Name = "btnGenerateNum";
            this.btnGenerateNum.Size = new System.Drawing.Size(169, 29);
            this.btnGenerateNum.TabIndex = 25;
            this.btnGenerateNum.Text = "Generate Numbers ";
            this.btnGenerateNum.UseVisualStyleBackColor = true;
            this.btnGenerateNum.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // nudTotalNumbers
            // 
            this.nudTotalNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotalNumbers.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTotalNumbers.Location = new System.Drawing.Point(23, 32);
            this.nudTotalNumbers.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTotalNumbers.Name = "nudTotalNumbers";
            this.nudTotalNumbers.Size = new System.Drawing.Size(120, 27);
            this.nudTotalNumbers.TabIndex = 24;
            this.toolTip1.SetToolTip(this.nudTotalNumbers, "Arrows increase by a factor of 10000. Manual edition is also allowed.");
            this.nudTotalNumbers.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bubble Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Heap Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Merge Method";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(625, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "List<int> Method";
            // 
            // FrmComparative
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(808, 497);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInternal);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.lbETInternal);
            this.Controls.Add(this.lbETMerge);
            this.Controls.Add(this.lbETHeap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbETBublle);
            this.Controls.Add(this.lbInternal);
            this.Controls.Add(this.lbMerge);
            this.Controls.Add(this.lbHeap);
            this.Controls.Add(this.lbBubble);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComparative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorting Methods Comparative";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotalNumbers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBubble;
        private System.Windows.Forms.ListBox lbHeap;
        private System.Windows.Forms.ListBox lbMerge;
        private System.Windows.Forms.ListBox lbInternal;
        private System.Windows.Forms.Label lbETBublle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Label lbETInternal;
        private System.Windows.Forms.Label lbETMerge;
        private System.Windows.Forms.Label lbETHeap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnInternal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateNum;
        private System.Windows.Forms.NumericUpDown nudTotalNumbers;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
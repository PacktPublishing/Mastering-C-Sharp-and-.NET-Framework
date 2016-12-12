namespace Interop1
{
    partial class fmInteropExcel
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
            this.btnOpenExcel = new System.Windows.Forms.Button();
            this.btnFormatCells = new System.Windows.Forms.Button();
            this.btnGenerateGraph = new System.Windows.Forms.Button();
            this.pbChart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.Location = new System.Drawing.Point(28, 25);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(89, 39);
            this.btnOpenExcel.TabIndex = 0;
            this.btnOpenExcel.Text = "Open Excel";
            this.btnOpenExcel.UseVisualStyleBackColor = true;
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // btnFormatCells
            // 
            this.btnFormatCells.Location = new System.Drawing.Point(186, 25);
            this.btnFormatCells.Name = "btnFormatCells";
            this.btnFormatCells.Size = new System.Drawing.Size(150, 39);
            this.btnFormatCells.TabIndex = 1;
            this.btnFormatCells.Text = "Format Cells";
            this.btnFormatCells.UseVisualStyleBackColor = true;
            // 
            // btnGenerateGraph
            // 
            this.btnGenerateGraph.Location = new System.Drawing.Point(411, 25);
            this.btnGenerateGraph.Name = "btnGenerateGraph";
            this.btnGenerateGraph.Size = new System.Drawing.Size(156, 39);
            this.btnGenerateGraph.TabIndex = 3;
            this.btnGenerateGraph.Text = "Generate GraphChart";
            this.btnGenerateGraph.UseVisualStyleBackColor = true;
            this.btnGenerateGraph.Click += new System.EventHandler(this.btnGenerateGraph_Click);
            // 
            // pbChart
            // 
            this.pbChart.Location = new System.Drawing.Point(28, 96);
            this.pbChart.Name = "pbChart";
            this.pbChart.Size = new System.Drawing.Size(539, 260);
            this.pbChart.TabIndex = 4;
            this.pbChart.TabStop = false;
            // 
            // frmInteropExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.Controls.Add(this.pbChart);
            this.Controls.Add(this.btnGenerateGraph);
            this.Controls.Add(this.btnFormatCells);
            this.Controls.Add(this.btnOpenExcel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInteropExcel";
            this.Text = "Demo of Interop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInteropExcel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenExcel;
        private System.Windows.Forms.Button btnFormatCells;
        private System.Windows.Forms.Button btnGenerateGraph;
        private System.Windows.Forms.PictureBox pbChart;
    }
}


namespace DemoParallelClass
{
    partial class ParallelForDemo
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
            this.btnStandardFor = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnParallelFor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStandardFor
            // 
            this.btnStandardFor.Location = new System.Drawing.Point(27, 25);
            this.btnStandardFor.Name = "btnStandardFor";
            this.btnStandardFor.Size = new System.Drawing.Size(124, 31);
            this.btnStandardFor.TabIndex = 0;
            this.btnStandardFor.Text = "Standard For";
            this.btnStandardFor.UseVisualStyleBackColor = true;
            this.btnStandardFor.Click += new System.EventHandler(this.btnStandardFor_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(27, 94);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(669, 281);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            // 
            // btnParallelFor
            // 
            this.btnParallelFor.Location = new System.Drawing.Point(214, 25);
            this.btnParallelFor.Name = "btnParallelFor";
            this.btnParallelFor.Size = new System.Drawing.Size(124, 31);
            this.btnParallelFor.TabIndex = 2;
            this.btnParallelFor.Text = "Parallel For";
            this.btnParallelFor.UseVisualStyleBackColor = true;
            this.btnParallelFor.Click += new System.EventHandler(this.btnParallelFor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elapsed Time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Elapsed Time: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 401);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParallelFor);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnStandardFor);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Class Parallel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStandardFor;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnParallelFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


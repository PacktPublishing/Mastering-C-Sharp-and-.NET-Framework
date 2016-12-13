namespace DemoParallelClass
{
    partial class ParallelForEachDemo
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
            this.lblForEachStandard = new System.Windows.Forms.Label();
            this.lblParallel = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForEachStandard
            // 
            this.lblForEachStandard.AutoSize = true;
            this.lblForEachStandard.Location = new System.Drawing.Point(18, 87);
            this.lblForEachStandard.Name = "lblForEachStandard";
            this.lblForEachStandard.Size = new System.Drawing.Size(221, 21);
            this.lblForEachStandard.TabIndex = 0;
            this.lblForEachStandard.Text = "Time for standard ForEach:  ";
            // 
            // lblParallel
            // 
            this.lblParallel.AutoSize = true;
            this.lblParallel.Location = new System.Drawing.Point(27, 124);
            this.lblParallel.Name = "lblParallel";
            this.lblParallel.Size = new System.Drawing.Size(212, 21);
            this.lblParallel.TabIndex = 1;
            this.lblParallel.Text = "Time for Parallel ForEach:  ";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(22, 24);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(405, 43);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch Process of Images (both modes)";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // ParallelForEachDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 182);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblParallel);
            this.Controls.Add(this.lblForEachStandard);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ParallelForEachDemo";
            this.Text = "ParallelForEachDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForEachStandard;
        private System.Windows.Forms.Label lblParallel;
        private System.Windows.Forms.Button btnLaunch;
    }
}
namespace Interop1
{
    partial class fmInteropWord
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
            this.btnSpellCheck = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnOpenWord = new System.Windows.Forms.Button();
            this.rtbSpellingText = new System.Windows.Forms.RichTextBox();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpellCheck
            // 
            this.btnSpellCheck.Location = new System.Drawing.Point(369, 23);
            this.btnSpellCheck.Name = "btnSpellCheck";
            this.btnSpellCheck.Size = new System.Drawing.Size(118, 39);
            this.btnSpellCheck.TabIndex = 6;
            this.btnSpellCheck.Text = "Spell Check";
            this.btnSpellCheck.UseVisualStyleBackColor = true;
            this.btnSpellCheck.Click += new System.EventHandler(this.btnSpellCheck_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(268, 23);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(84, 39);
            this.btnFormat.TabIndex = 5;
            this.btnFormat.Text = "Format Paragraph";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnOpenWord
            // 
            this.btnOpenWord.Location = new System.Drawing.Point(24, 23);
            this.btnOpenWord.Name = "btnOpenWord";
            this.btnOpenWord.Size = new System.Drawing.Size(89, 39);
            this.btnOpenWord.TabIndex = 4;
            this.btnOpenWord.Text = "Open Word";
            this.btnOpenWord.UseVisualStyleBackColor = true;
            this.btnOpenWord.Click += new System.EventHandler(this.btnOpenWord_Click);
            // 
            // rtbSpellingText
            // 
            this.rtbSpellingText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSpellingText.Location = new System.Drawing.Point(24, 95);
            this.rtbSpellingText.Name = "rtbSpellingText";
            this.rtbSpellingText.Size = new System.Drawing.Size(463, 114);
            this.rtbSpellingText.TabIndex = 7;
            this.rtbSpellingText.Text = "This tex contains speling errors. Please corect it.";
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(133, 23);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(84, 39);
            this.btnInsertImage.TabIndex = 8;
            this.btnInsertImage.Text = "Insert image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // fmInteropWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 237);
            this.Controls.Add(this.btnInsertImage);
            this.Controls.Add(this.rtbSpellingText);
            this.Controls.Add(this.btnSpellCheck);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnOpenWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmInteropWord";
            this.Text = "Interop Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmInteropWord_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpellCheck;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnOpenWord;
        private System.Windows.Forms.RichTextBox rtbSpellingText;
        private System.Windows.Forms.Button btnInsertImage;
    }
}
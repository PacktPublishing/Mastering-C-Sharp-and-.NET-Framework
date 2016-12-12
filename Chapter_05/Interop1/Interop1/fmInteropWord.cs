using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Globalization;

namespace Interop1
{
    public partial class fmInteropWord : Form
    {

        public fmInteropWord()
        {
            InitializeComponent();
        }
        Word.Application word = new Word.Application();
        private void btnOpenWord_Click(object sender, EventArgs e)
        {
            word.Visible = true;
            word.Documents.Add();

            var theDate = DateTime.Today.ToString(CultureInfo.CreateSpecificCulture("en-US"));
            word.Selection.InsertAfter(theDate + Environment.NewLine);
            word.Selection.InsertAfter("This text is passed to Word directly." +
                Environment.NewLine);
            word.Selection.InsertAfter("Number or paragraphs: " +
                word.ActiveDocument.Paragraphs.Count.ToString());
        }
        private void fmInteropWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                word.ActiveDocument.Saved = true;
                word.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("Word already closed or not present");
            }
        }
        private void btnFormat_Click(object sender, EventArgs e)
        {
            Word.Range firstPara = word.ActiveDocument.Paragraphs[1].Range;
            firstPara.Font.Size = 21;
            firstPara.Font.Name = "Century Gothic";
            firstPara.ParagraphFormat.Alignment = 
                Word.WdParagraphAlignment.wdAlignParagraphCenter;
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            var filePath = Environment.CurrentDirectory;
            word.Selection.InsertAfter(Environment.NewLine + "Logo PACKT: ");
            var numChars = word.Selection.Characters.Count;
            word.Selection.InlineShapes.AddPicture(filePath + "\\Packt.jpg",
                Range: word.ActiveDocument.Range(numChars));
        }
        private string SpellCheck(string text)
        {
            var corrected = string.Empty;
            var doc = word.ActiveDocument;
            if (!string.IsNullOrEmpty(text))
            {
                doc.Words.Last.InsertAfter(Environment.NewLine + text);
                var corRange = doc.Paragraphs.Last.Range;
                corRange.CheckSpelling();
                corrected = corRange.Text;
            }
            return corrected;
        }
        private void btnSpellCheck_Click(object sender, EventArgs e)
        {
            if (word.Documents.Count >= 1)
                rtbSpellingText.Text += 
                    Environment.NewLine + Environment.NewLine +
                    SpellCheck(rtbSpellingText.Text);
            else
                MessageBox.Show("Please, use the 'Open Word' option first");
        }
    }
}

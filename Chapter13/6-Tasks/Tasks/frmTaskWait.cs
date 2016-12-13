using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class frmTaskWait : Form
    {
        public frmTaskWait()
        {
            InitializeComponent();
        }

        private void btnProcessImages_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Tasks finished:   ";
            var t1 = Task.Factory.StartNew(() => pictureBox1.Image =
               Properties.Resources.Hockney_2FIGURES);
            t1.ContinueWith((t) => lblMessage.Text += " t1-",
               TaskScheduler.FromCurrentSynchronizationContext());
            var t2 = Task.Factory.StartNew(() => pictureBox2.Image =
               BitmapInvertColors(Properties.Resources.Hockney_2FIGURES));
            t2.ContinueWith((t) => lblMessage.Text += " t2-",
               TaskScheduler.FromCurrentSynchronizationContext());
            var t3 = Task.Factory.StartNew(() => pictureBox3.Image =
               MakeGrayscale(Properties.Resources.Hockney_2FIGURES));
            t3.ContinueWith((t) => lblMessage.Text += " t3-",
               TaskScheduler.FromCurrentSynchronizationContext());
            var t4 = Task.Factory.StartNew(() => pictureBox4.Image =
                CorrectGamma(Properties.Resources.Hockney_2FIGURES, 2.5m));
            //var t6 = Task.Factory.StartNew(() => Loop());
            t4.ContinueWith((t) => lblMessage.Text += " t4-",
                TaskScheduler.FromCurrentSynchronizationContext());
            var t5 = Task.Factory.ContinueWhenAll(new[] { t1, t2, t3, t4 }, (t) =>
            {
                Thread.Sleep(50);
            });
            t5.ContinueWith((t) => lblMessage.Text += " -All finished",
                TaskScheduler.FromCurrentSynchronizationContext());
        }
        // Thanks to WholsRich for this algorithm published in StackOverflow
        public static Bitmap BitmapInvertColors(Bitmap bitmapImage)
        {
            var bitmapRead = bitmapImage.LockBits(new Rectangle(0, 0, bitmapImage.Width,
                bitmapImage.Height),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
            var bitmapLength = bitmapRead.Stride * bitmapRead.Height;
            var bitmapBGRA = new byte[bitmapLength];
            Marshal.Copy(bitmapRead.Scan0, bitmapBGRA, 0, bitmapLength);
            bitmapImage.UnlockBits(bitmapRead);

            for (int i = 0; i < bitmapLength; i += 4)
            {
                bitmapBGRA[i] = (byte)(255 - bitmapBGRA[i]);
                bitmapBGRA[i + 1] = (byte)(255 - bitmapBGRA[i + 1]);
                bitmapBGRA[i + 2] = (byte)(255 - bitmapBGRA[i + 2]);
                //        [i + 3] = ALPHA.
            }

            var bitmapWrite = bitmapImage.LockBits(new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            Marshal.Copy(bitmapBGRA, 0, bitmapWrite.Scan0, bitmapLength);
            bitmapImage.UnlockBits(bitmapWrite);
            return bitmapImage;
        }

        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        // Taken from Bogdan Chernyachuk's "Applying Gamma correction to an Image"
        public static Bitmap CorrectGamma(Image source, decimal gamma)
        {
            Bitmap intermediate = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppPArgb);

            // Create an ImageAttributes object and set the gamma
            ImageAttributes imageAttr = new ImageAttributes();
            imageAttr.SetGamma(Convert.ToSingle(gamma));

            Rectangle rect = new Rectangle(0, 0, source.Width, source.Height);
            using (Graphics g = Graphics.FromImage(intermediate))
            {
                g.DrawImage(source, rect, 0, 0, source.Width, source.Height, GraphicsUnit.Pixel);
            }

            Bitmap corrected = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppPArgb);
            using (Graphics g = Graphics.FromImage(corrected))
            {
                g.DrawImage(intermediate, rect, 0, 0, intermediate.Width, intermediate.Height, GraphicsUnit.Pixel, imageAttr);
            }

            intermediate.Dispose();
            return corrected;
        }

    }
}

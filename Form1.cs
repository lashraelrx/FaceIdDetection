using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FaceDetection
{
    public partial class Form1 : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("necmi.xml");
        public string FolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    FolderPath = fbd.SelectedPath;
                    folderBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void idButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(FolderPath))
            {
                MessageBox.Show("You must select a folder first.");
            }
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderPath))
            {
                MessageBox.Show("You must select a folder first.");
            }
            var Photos = GatherPhotos();
            for (var i = 0; i < Photos.Count; i++)
            {
                Bitmap img = new Bitmap(Image.FromFile(Photos[i]));
                BitmapData bitmapData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, img.PixelFormat);
                //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(img.Width, img.Height, bitmapData.Stride, bitmapData.Scan0);
                img.UnlockBits(bitmapData);

                Image<Bgr, byte> grayImage = new Image<Bgr, byte>(img);

                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(image: grayImage, scaleFactor: 1.2, minNeighbors: 1);
                //Console.WriteLine(rectangles.Count().ToString() + " " + Photos[i]);
                if(rectangles.Count().ToString() == "0")
                {
                    //Console.Write(Photos[i] + " is not a valid face.");
                    Append(Photos[i] + " is not valid");
                    //continue;
                } else
                {
                    Append(Photos[i] + " is valid");
                }
                /*/
                foreach(Rectangle rectangle in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(img))
                    using(Pen pen = new Pen(Brushes.Red))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
                /*/
            }
        }
        private List<string> GatherPhotos()
        {
            var files = Directory.GetFiles(@"" + FolderPath, "*.*", SearchOption.TopDirectoryOnly);
            List<string> imageFiles = new List<string>();
            foreach(string filename in files)
            {
                if(Regex.IsMatch(filename, @"\.jpg$|\.jpeg$"))
                {
                    imageFiles.Add(filename);
                }
            }
            return imageFiles;
        }
        private void Append(String text)
        {
            logBox.Text += "\n" + text;
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageCorruptor
{
    public partial class Form1 : Form
    {
        public string fileName;
        public Random random = new Random();
        public int percent = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //FileStream file = new FileStream("Path to File", FileMode.Open);
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "image files(*.JPG;*.PNG)|*.JPG;*.PNG|All Files (*.*)|*.*";
            file.FilterIndex = 1;
            file.Multiselect = false;

            if(file.ShowDialog() == DialogResult.OK)
            {
                fileName = file.FileName;
            }
            //MessageBox.Show(fileName);
            try
            {
                Bitmap image = (Bitmap)Image.FromFile(fileName, true);
                picBoxOld.Image = (Bitmap)Image.FromFile(fileName, true);
                picBoxNew.Image = Corrupt(image);
            }
            catch (FileNotFoundException)
            {

            }
        }

        private Bitmap Corrupt(Bitmap newImage)
        {
            //Bitmap newImage = image;
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    if (IsCorrupt())
                    {
                        newImage.SetPixel(i, j, NewColor());
                    }
                }
            }

            return newImage;
        }

        private Color NewColor()
        {
            Color newColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            return newColor;
        }

        private void nudPercent_ValueChanged(object sender, EventArgs e)
        {
            percent = (int)nudPercent.Value;
        }

        private bool IsCorrupt()
        {
            if(random.Next(100) <= percent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

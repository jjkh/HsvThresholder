using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HsvThresholder
{
    public partial class hsvThreshForm : Form
    {
        Image<Hsv, Byte> srcImage = null;
        Image<Gray, Byte> threshImage = null;

        public hsvThreshForm()
        {
            InitializeComponent();
        }

        private void openImageBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                LoadImage(openFileDialog.FileName);
        }

        private void LoadImage(string fileName)
        {
            srcImage = new Image<Hsv, byte>(fileName);
            srcPicBox.Image = srcImage.Resize(srcPicBox.Width, srcPicBox.Height, Emgu.CV.CvEnum.Inter.Area, true).ToBitmap();

            hueMinTrackBar.Enabled = true;
            hueMaxTrackBar.Enabled = true;
            satMinTrackBar.Enabled = true;
            satMaxTrackBar.Enabled = true;
            valMinTrackBar.Enabled = true;
            valMaxTrackBar.Enabled = true;
        }

        private void ResizeImages(object sender = null, EventArgs e = null)
        {
            if (srcImage != null)
                srcPicBox.Image = srcImage.Resize(srcPicBox.Width, srcPicBox.Height, Emgu.CV.CvEnum.Inter.Area, true).ToBitmap();
            if (threshImage != null)
                threshPicBox.Image = threshImage.Resize(srcPicBox.Width, srcPicBox.Height, Emgu.CV.CvEnum.Inter.Area, true).ToBitmap();
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            Hsv minHsv = new Hsv(hueMinTrackBar.Value, satMinTrackBar.Value, valMinTrackBar.Value);
            Hsv maxHsv = new Hsv(hueMaxTrackBar.Value, satMaxTrackBar.Value, valMaxTrackBar.Value);
            hueLabel.Text = String.Format("{0} - {1}", minHsv.Hue, maxHsv.Hue);
            satLabel.Text = String.Format("{0} - {1}", minHsv.Satuation, maxHsv.Satuation);
            valLabel.Text = String.Format("{0} - {1}", minHsv.Value, maxHsv.Value);

            outTxtBox.Text = String.Format("threshImage = srcImage.InRange(new Hsv({0}, {1}, {2}), new Hsv({3}, {4}, {5}));",
                minHsv.Hue, minHsv.Satuation, minHsv.Value, maxHsv.Hue, maxHsv.Satuation, maxHsv.Value);
            
            threshImage = srcImage.InRange(minHsv, maxHsv);
            threshPicBox.Image = threshImage.Resize(srcPicBox.Width, srcPicBox.Height, Emgu.CV.CvEnum.Inter.Area, true).ToBitmap();
        }
    }
}

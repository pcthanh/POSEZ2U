using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSEZ2U.UC
{
    public partial class ImageViewer : System.Windows.Forms.PictureBox
    {
        private string[] mFiles;

        private int mIndex;

        private System.Windows.Forms.Timer mTimer;

        public ImageViewer()
        {
            //this.ImageLinkFolder = imageLF;
            mTimer = new System.Windows.Forms.Timer();
            mTimer = new System.Windows.Forms.Timer();

            mTimer.Interval = 3000;
            mTimer.Tick += new EventHandler(mTimer_Tick);

        }

        public string ImageLinkFolder { get; set; }

        public void SetInterval(int milisecond)
        {
            this.mTimer.Interval = milisecond;
        }

        public void Start()
        {
            //if (ImageLinkFolder != "")
            //{
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string mImageFullFolder = System.IO.Path.GetDirectoryName(path) + "\\posImage";
            //string mImageFullFolder = BusinessObject.BOConfig.GetCustomerImage;
            //string mImageFullFolder = "";
            if (System.IO.Directory.Exists(mImageFullFolder))
            {
                mFiles = System.IO.Directory.GetFiles(mImageFullFolder);
            }
            else
            {
                System.IO.Directory.CreateDirectory(mImageFullFolder);
            }
            mIndex = 0;
            ShowImage();
            mTimer.Start();
            //}
        }

        public void Stop()
        {
            this.mTimer.Stop();
        }

        private void mTimer_Tick(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void ShowImage()
        {
            if (mFiles != null)
            {
                if (mFiles.Length > 0)
                {
                    if (mIndex >= mFiles.Length)
                    {
                        mIndex = 0;
                    }
                    this.ImageLocation = mFiles[mIndex];
                    mIndex++;
                }
            }
        }
    }
}

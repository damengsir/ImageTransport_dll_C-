using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace ImageTransGUI
{
    public partial class Form1 : Form
    {

#if DEBUG
        const string DllName = "ImageTransd.dll";
#else
        const string DllName = "ImageTrans.dll";
#endif

        [DllImport(DllName, EntryPoint = "ImageProcess", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImageProcess(IntPtr img, int width, int height, int step);

        

        public Form1()
        {
            InitializeComponent();
        }

     
        private void ReadImage_Click(object sender, EventArgs e)
        {
            //读取图像方法一
            //{
            //    pictureBoxRead.SizeMode = PictureBoxSizeMode.StretchImage;
            //    Image myImage = Image.FromFile(@"D:/1.jpg");
            //    pictureBoxRead.Image = myImage;
            //}

            {
                //1、Bitmap图像读取,并显示在控件上
                Bitmap bmp = new Bitmap("D:/UVSS1.jpg");
                Image img = Image.FromHbitmap(bmp.GetHbitmap());
                pictureBoxRead.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxRead.Image = img;


                //2、锁定内存变成指针形式
                BitmapData bitmapData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

          
                //3、调用Dll处理
                Form1.ImageProcess(bitmapData.Scan0, bitmapData.Width, bitmapData.Height, bitmapData.Stride);

                //4、//解除锁定内存
                bmp.UnlockBits(bitmapData);
                

                //5、显示处理后的图像
                Image Img2 = Image.FromHbitmap(bmp.GetHbitmap());
                pictureBoxReturn.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxReturn.Image = Img2;

            }
            
        }


    }
}

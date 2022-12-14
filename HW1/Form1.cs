using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//นำเข้าส่วนที่ต้องใช้เกี่ยวกับ ภาพ
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using System.Windows.Forms;
using System.Drawing;

namespace HW1
{
    public partial class Form1 : Form
    {
        private Bitmap m_bmSource;         //ส่วนนี้เพิ่มเข้ามาเพื่อแก้ error
        private Image<Rgb, byte> m_imS;    //ส่วนนี้เพิ่มเข้ามาเพื่อแก้ error

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conv2_ex();  //สั่งให้ฟังก์ชันทำงานหลังจากที่กดปุ่ม
        }
        //-----------------ฟังก์ชันวิธีการ สำหรับการแปลงภาพบิตแมพ (Bitmap) ให้สอดคล้องกับรูปแบบที่กำหนดใน  ไลบราลี่ EmguCV(bm2im)-----------------------
        private Image<Bgr, byte> bm2im(Bitmap bm)
        {
            BitmapData InputBitmapData0 = bm.LockBits(new Rectangle(0, 0, bm.Width,
            bm.Height), ImageLockMode.ReadOnly,
            bm.PixelFormat);

            IntPtr ptr0 = InputBitmapData0.Scan0;
            int stride0 = InputBitmapData0.Stride;
            byte[] byteArray = new byte[InputBitmapData0.Stride * bm.Height];
            Marshal.Copy(ptr0, byteArray, 0, byteArray.Length);
            Image<Bgr, Byte> source = new Image<Bgr, Byte>(bm.Width, bm.Height, stride0,

            ptr0);

            bm.UnlockBits(InputBitmapData0);
            return source;
        }
        //-----------------------------------------------------------------------------------------------------------------------
        //โค๊ดส่วนที่ใช้จัดการรูปภาพ
        private void conv2_ex()
        {

            string m_strpath = "C:\\Users\\patta\\Downloads\\Photos\\happydog.jpeg";

            m_bmSource = new Bitmap(m_strpath);
            m_imS = bm2im(m_bmSource).Convert<Rgb, byte>();
            ConvolutionKernelF avgkernel = new ConvolutionKernelF(new float[,] {
                                                
                                                //sobel 
                                                { 1.0f,2.0f,1.0f },
                                                { 0.0f,0.0f,0.0f },
                                                { -1.0f,-2.0f,-1.0f } });

                                                /*  ภาพขาวดำ
                                                { 0.11f,10.0f,0.11f },
                                                { -0.11f,-100.0f,-0.11f },
                                                { 0.11f,10.0f,0.11f } });
                                                */

                                                /*  ตามหนังสือ อาจารย์
                                                { 1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f},
                                                { 1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f},
                                                { 1.0f/9.0f, 1.0f/9.0f, 1.0f/9.0f} }); 
                                                */



            Image<Gray, float> f_img = m_imS.Convert<Gray, float>();
            Image<Gray, float> g_img = f_img.Convolution(avgkernel);

            picView_1.Image = f_img.ToBitmap();
            picView_2.Image = g_img.ToBitmap();
        }


    }
}

using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class test
    {
        static void Main(string[] args)
        {
            t();
        }
        /// <summary>
        /// 测试opencvsharp
        /// </summary>
        public static void t()
        {
            //Mat girl = ImreadModes("D:\\img\data\lena.jpg"); //载入图像到Mat  
            //imshow("【1】动漫图", girl);//显示名为 "【1】动漫图"的窗口   
            //Window.WaitKey();
            Mat src = Cv2.ImRead("D:/img/data/lenna.png", ImreadModes.GrayScale); 
            Mat dst = new Mat();
            Cv2.Canny(src,dst,50,200);
            Cv2.NamedWindow("hello");
            Cv2.ImShow("hello", dst);
            //使用（新 窗口（“ dst图像”，dst））
            Cv2.WaitKey();
        }
    }
}

using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYStem.Scoring
{
    class ScoringObjective
    {
        public static void saomiao()
        {
            using (var srcImg1 = Cv2.ImRead(@"D:\img\scoring\keguanti.png", 0))
            {
                Mat srcImg2 = new Mat();
                Mat srcImg3 = new Mat();
                Mat srcImg4 = new Mat();
                Mat srcImg5=new Mat();
                //srcImg1.CopyTo(srcImg2);
                using (var element= Cv2.GetStructuringElement(MorphShapes.Rect, new Size(4, 4)))
                {
                    Cv2.Erode(srcImg1, srcImg2, element);//腐蚀
                    Cv2.Dilate(srcImg2,srcImg3,element);//膨胀

                    Cv2.NamedWindow("腐蚀", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
                    Cv2.ImShow("腐蚀", srcImg2);

                    Cv2.NamedWindow("膨胀", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
                    Cv2.ImShow("膨胀", srcImg3);

                    //确定每张答题卡的ROI区域 
                    Mat imag_ch2 = new Mat(srcImg3, new Rect(60, 135, 400, 60));
                    Mat imag_ch1 = new Mat(srcImg3,new Rect(60, 225, 400, 105));
                    //Mat imag_ch3 = new Mat(srcImg3, new Rect(60, 360, 400, 70));

                    Cv2.NamedWindow("img1", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
                    Cv2.ImShow("img1", imag_ch1);

                    Cv2.NamedWindow("img2", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
                    Cv2.ImShow("img2", imag_ch2);

                    Cv2.NamedWindow("img3", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
                    Cv2.ImShow("img3", srcImg1);
                    Cv2.WaitKey();
                }
            }
        }
        
    }
}

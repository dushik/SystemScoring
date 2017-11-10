using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opencvDemo
{
    public class tempMatch
    {
        public static void tempmatch()
        {
            zhifangtu.funzhifang();//直方图投影
            Mat paperImg = Cv2.ImRead(@"D:\img\scoring\paper.bmp", 0);  //读入黑白原始图像
            Mat temImg = Cv2.ImRead(@"D:\img\scoring\tem.bmp", 0);
            Cv2.NamedWindow("hello", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
            Cv2.ImShow("hello", paperImg);
            Cv2.NamedWindow("hi", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
            //Cv2.ImShow("hi", temImg);
            Mat imgMatch = new Mat();
            int paperRows = paperImg.Rows;
            int paperCols = paperImg.Cols;
            Mat p1 = new Mat(imgMatch.Clone());
            Mat p2 = new Mat(imgMatch.Clone());
            Mat p3 = new Mat(imgMatch.Clone());
            Mat p4 = new Mat(imgMatch.Clone());
            //设置匹配的兴趣区域，提高效率
            //paperImg.CopyTo(imgMatch);
            Mat paper01 = new Mat(p1, new Rect(0, 0, paperRows / 2, paperCols / 2));
            Mat paper02 = new Mat(p2, new Rect(paperRows / 2, 0, paperRows / 2, paperCols / 2));
            //Mat paper03 = new Mat(paperImg,new Rect(0, paperCols * 2 / 3, paperRows / 3, paperCols / 3));
            //Mat paper04 = new Mat(paperImg,new Rect(paperRows * 2 / 3, paperCols * 2 / 3, paperRows / 3, paperCols / 3));
            matchfun(paper01, temImg);
            matchfun(paper02, temImg);
            //显示匹配位置是否正确
            Cv2.ImShow("hi", imgMatch);
            Cv2.NamedWindow("1", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
            Cv2.ImShow("1", paper01);
            Cv2.NamedWindow("2", flags: WindowMode.AutoSize | WindowMode.FreeRatio);
            Cv2.ImShow("2", paper02);
            Cv2.WaitKey();
            //Mat matchResult;
            //matchResult.Create();
        }
        public static void matchfun(Mat imgMatch, Mat temImg)
        {
            Point minLoc, maxLoc, matchLoc;
            double maxValue, minValue;
            //进行匹配和标准化
            Cv2.MatchTemplate(imgMatch, temImg, imgMatch, TemplateMatchModes.CCoeffNormed);  //归一化相关系数匹配法
            Cv2.Normalize(imgMatch, imgMatch, 0, 1, NormTypes.MinMax, -1);
            //通过函数 minMaxLoc 定位最匹配的位置
            Cv2.MinMaxLoc(imgMatch, out minValue, out maxValue, out minLoc, out maxLoc);
            //除了平方差匹配法和归一化平方差匹配法，其余匹配法匹配，越大的数值匹配效果越好
            matchLoc = maxLoc;
            //绘制出匹配的位置
            //Point rt = new Point(matchLoc.X, matchLoc.Y);
            Point lb = new Point(matchLoc.X + temImg.Cols, matchLoc.Y + temImg.Rows);
            Cv2.Rectangle(imgMatch, matchLoc, lb, Scalar.Red, 1, LineTypes.Link8, 0);
        }
    }
}

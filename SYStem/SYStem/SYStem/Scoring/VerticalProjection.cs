using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYStem.Scoring
{
    class VerticalProjection
    {
        public static int[] getVerProjArray(Mat matTmp)
        {
            int maxCol, maxNum, minCol, minNum;
            maxCol = 0; maxNum = 0;//重置255最大数目和最大行
            minCol = 0; minNum = matTmp.Rows;//重置255最小数目和最小行
	        int height = matTmp.Rows, width = matTmp.Cols;//图像的高和宽
                int tmp = 0;//保存当前行的255数目
                int[] projArray = new int[width];//保存每一行255数目的数组
	        for (int col = 0; col<width; ++col)
	        {
		        tmp = 0;
		        for (int row = 0; row<height; ++row)
		        {
			        //if (matTmp.Get<Vec2b>(row, col) == 0)
           //             matTmp.Get<Vec2b>(row, col)
			        //{
				       // ++tmp;
			        //}
        }
        projArray[col] = tmp;
		        if (tmp > maxNum)
		        {
			        maxNum = tmp;
			        maxCol = col;
		        }
		        if (tmp<minNum)
		        {
			        minNum = tmp;
			        minCol = col;
		        }
	        }
	        return  projArray;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 阅卷结果表实体类
    /// </summary>
    public class examination
    {
        public int id { get; set; }
        public int number { get; set; }
        public float ltx { get; set; }
        public float lty { get; set; }
        public float lbx { get; set; }
        public float lby { get; set; }
        public float rtx { get; set; }
        public float rty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 考试信息实体类
    /// </summary>
    public class test
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime updateDate { get; set; }
        public int uid { get; set; }
    }
}

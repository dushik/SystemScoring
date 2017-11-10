using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 学生实体类
    /// </summary>
    public class student
    {
        public int id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int classId { get; set; }
        public DateTime updateDate { get; set; }
        public int uid { get; set; }
    }
}

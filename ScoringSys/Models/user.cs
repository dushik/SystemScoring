using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 
    /// 用户信息实体类
    /// </summary>
    public class user
    {
        public int id { get; set; }
        public string username { get; set; }
        public string pword { get; set; }
        public DateTime updateDate { get; set; }
        public int uid{get;set;}
    }
}

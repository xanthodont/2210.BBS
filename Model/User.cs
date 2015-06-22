using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class User : BaseModel {

        public string UserName { get; set; }

        public string NickName { get; set; }

        public string RealName { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// 密码提示问题
        /// </summary>
        public string PsdQ { get; set; }

        /// <summary>
        /// 密码提示答案
        /// </summary>
        public string PsdA { get; set; }

        public Sex Sex { get; set; }

        public DateTime Brithday { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string ZipCode { get; set; }

        public DateTime LastLoginTime { get; set; }
    }

    public enum Sex {
        男 = 1,
        女 = 2,
    }
}

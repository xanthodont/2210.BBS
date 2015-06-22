using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    /// <summary>
    /// 评分系统
    /// </summary>
    public class Grade : BaseModel {

        /// <summary>
        /// 分数
        /// </summary>
        public int Score { get; set; }

        public Guid MsgID { get; set; }

        public Message Msg { get; set; }
    }
}

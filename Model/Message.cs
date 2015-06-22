using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Message : BaseModel {

        public Guid FromUserID { get; set; }

        public Guid ToUserID { get; set; }

        /// <summary>
        /// 原始信件ID
        /// </summary>
        public Guid MsgID { get; set; }

        /// <summary>
        /// 信件编号
        /// </summary>
        public string MsgCode { get; set; }

        public MessageType MessageType { get; set; }

        /// <summary>
        /// 是否公开
        /// </summary>
        public bool IsPublic { get; set; }

        public string Title { get; set; }

        public string Contant { get; set; }

        /// <summary>
        /// 回信时原始信件
        /// </summary>
        public Message OriginalMessage { get; set; }
    }

    public enum MessageType {
        求助 = 1,
        咨询 = 2,
        投诉 = 4,
        其他 = 8,
    }
}

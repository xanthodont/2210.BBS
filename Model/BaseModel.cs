using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public  class BaseModel
    {
       public Guid ID { get; set; }

       public DateTime CreateTime { get; set; }

       public DateTime LastModifyTime { get; set; }
    }
}

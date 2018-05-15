using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberDomain.BusinessObjects
{
    public abstract class QueryResponseBase
    {
        public virtual string Message { get; set; }
        public virtual bool Success { get; set; }
    }
}

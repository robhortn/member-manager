using MemberManager.BusinessObjects;
using System;
using System.Collections.Generic;

namespace MemberDomain.BusinessObjects
{
    public class MemberSearchResponse : QueryResponseBase
    {
        public MemberSearchResponse()
        {
            Exceptions = new List<Exception>();
        }

        public List<Exception> Exceptions { get; set; }
        public List<Member> Members { get; set; }
    }
}
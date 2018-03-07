using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.Domain.Interfaces;

namespace MemberManager.Domain
{
    public class Class1 : IDomainClass
    {
        public string TestCall()
        {
            return "Hey from Domain.TestCall()";
        }
    }
}

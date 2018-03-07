using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.Domain.Interfaces;

namespace MemberManager.Domain
{
    public class Class2 : IDomainClass2
    {
        public string TestCall()
        {
            return "Hey from Domain.Class2.TestCall() injected into Class1";
        }
    }
}

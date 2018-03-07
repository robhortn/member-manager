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
        private IDomainClass2 _domainClass2;

        public Class1(IDomainClass2 domainClass2)
        {
            _domainClass2 = domainClass2;
        }

        public string TestCall()
        {
            return "Hey from Domain.Class1.TestCall()";
        }

        public string TestCall2()
        {
            return _domainClass2.TestCall();
        }
    }
}

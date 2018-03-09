using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.Data.Interface;
using MemberManager.Domain.Interfaces;

namespace MemberManager.Domain
{
    public class MemberDomain : IMemberDomain
    {
        private IMemberDataWriter _dw;
        private IMemberRepo _repo;

        public MemberDomain(IMemberDataWriter dw, IMemberRepo repo)
        {
            _dw = dw;
            _repo = repo;
        }

        public string TestCall()
        {
            return "Hey from Domain.Class1.TestCall()";
        }
    }
}

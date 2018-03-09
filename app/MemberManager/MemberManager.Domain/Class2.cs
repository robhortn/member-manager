using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.Data.Interface;
using MemberManager.Domain.Interfaces;

namespace MemberManager.Domain
{
    public class Class2 : IDomainClass2
    {
        private IMemberRepo _repo;

        public Class2(IMemberRepo repo)
        {
            _repo = repo;
        }

        public string TestCall()
        {
            string response = _repo.DbCall(); //"Hey from Domain.Class2.TestCall() injected into Class1";
            return response;
        }
    }
}

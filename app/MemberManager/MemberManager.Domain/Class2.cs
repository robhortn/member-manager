using MemberManager.Data.Interface;
using MemberManager.Domain.Interfaces;
using System;

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
            throw new NotImplementedException();
        }
    }
}
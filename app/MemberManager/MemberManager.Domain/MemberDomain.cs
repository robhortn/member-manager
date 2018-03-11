using MemberManager.BusinessObjects;
using MemberManager.Interfaces;
using System;
using System.Linq;

namespace MemberManager.Domain
{
    public class MemberDomain : IMemberDomain
    {
        //private IMemberDataWriter _dw;
        private IMemberRepo _repo;

        public MemberDomain(IMemberRepo repo)
        {
            //_dw = dw;
            _repo = repo;
        }

        public string DbCall()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Member> Get()
        {
            throw new NotImplementedException();
        }

        public Member GetMember(int id)
        {
            return _repo.GetMember(id);
        }

        public int Save(Member member)
        {
            throw new NotImplementedException();
        }

        public string TestCall()
        {
            return "Hey from Domain.Class1.TestCall()";
        }
    }
}
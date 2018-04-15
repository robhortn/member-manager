using MemberManager.BusinessObjects;
using MemberManager.Interfaces;
using System;
using System.Collections.Generic;

namespace MemberManager.Domain
{
    public class MemberDomain : IMemberDomain
    {
        private IMemberRepo _repo;

        public MemberDomain(IMemberRepo repo)
        {
            _repo = repo;
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public ICollection<Member> Get()
        {
            return _repo.Get();
        }

        public Member GetMember(int id)
        {
            return _repo.GetMember(id);
        }

        public int Save(Member member)
        {
            return _repo.Save(member);
        }
    }
}
﻿using MemberManager.BusinessObjects;
using MemberManager.BusinessObjects.Queries;
using MemberManager.Interfaces;

using System.Collections.Generic;

namespace MemberManager.Domain
{
    public class MemberDomain : IMemberDomain
    {
        private readonly IMemberRepo _repo;

        public MemberDomain(IMemberRepo repo)
        {
            _repo = repo;
        }

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

        public ICollection<Member> Get(MemberQueryParameter query)
        {
            return _repo.Get(query);
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
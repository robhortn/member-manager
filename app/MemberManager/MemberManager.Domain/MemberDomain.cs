using System;
using MemberManager.BusinessObjects;
using MemberManager.Interfaces;

using System.Collections.Generic;
using MemberDomain.BusinessObjects;
using MemberDomain.BusinessObjects.Queries;
using MemberDomain.Interfaces;

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

        public MemberSearchResponse GetMember(int id)
        {
            MemberSearchResponse result = new MemberSearchResponse();
            try
            {
                if (id == 0)
                {
                    throw new NotSupportedException("Member Id given is invalid.");
                }

                return _repo.GetMember(id);
            }
            catch (Exception e)
            {
                result.Success = false;
                result.Exceptions.Add(e);
            }

            return result;
        }

        public int Save(Member member)
        {
            return _repo.Save(member);
        }
    }
}
using MemberManager.BusinessObjects;
using System.Collections.Generic;
using MemberDomain.BusinessObjects;
using MemberDomain.BusinessObjects.Queries;

namespace MemberManager.Interfaces
{
    public interface IMemberDomain
    {
        bool Delete(int id);

        ICollection<Member> Get(MemberQueryParameter query);

        MemberSearchResponse GetMember(int id);

        int Save(Member member);
    }
}
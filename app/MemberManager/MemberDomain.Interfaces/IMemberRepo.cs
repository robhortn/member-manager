using System.Collections.Generic;
using MemberDomain.BusinessObjects;
using MemberDomain.BusinessObjects.Queries;
using MemberManager.BusinessObjects;

namespace MemberDomain.Interfaces
{
    public interface IMemberRepo
    {
        ICollection<Member> Get(MemberQueryParameter query);

        MemberSearchResponse GetMember(int id);
        int Save(Member member);
        bool Delete(int id);
    }
}
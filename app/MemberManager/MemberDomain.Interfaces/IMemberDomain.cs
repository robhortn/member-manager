using MemberManager.BusinessObjects;
using MemberManager.BusinessObjects.Queries;
using System.Collections.Generic;

namespace MemberManager.Interfaces
{
    public interface IMemberDomain
    {
        bool Delete(int id);

        ICollection<Member> Get(MemberQueryParameter query);

        Member GetMember(int id);

        int Save(Member member);
    }
}
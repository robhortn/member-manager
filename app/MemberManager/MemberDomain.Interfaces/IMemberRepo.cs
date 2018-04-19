using System.Collections.Generic;
using MemberManager.BusinessObjects;
using MemberManager.BusinessObjects.Queries;

namespace MemberManager.Interfaces
{
    public interface IMemberRepo
    {
        ICollection<Member> Get(MemberQueryParameter query);

        Member GetMember(int id);
        int Save(Member member);
        bool Delete(int id);
    }
}
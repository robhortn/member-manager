using MemberManager.BusinessObjects;
using System.Collections.Generic;

namespace MemberManager.Interfaces
{
    public interface IMemberDomain
    {
        bool Delete(int id);

        List<Member> Get();

        Member GetMember(int id);

        int Save(Member member);
    }
}
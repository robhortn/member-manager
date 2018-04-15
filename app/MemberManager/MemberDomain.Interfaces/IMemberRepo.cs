using System.Collections.Generic;
using MemberManager.BusinessObjects;

namespace MemberManager.Interfaces
{
    public interface IMemberRepo
    {
        ICollection<Member> Get();

        Member GetMember(int id);
        int Save(Member member);
        bool Delete(int id);
    }
}
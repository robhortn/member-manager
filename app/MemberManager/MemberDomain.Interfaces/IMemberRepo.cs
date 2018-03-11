using System.Linq;
using MemberManager.BusinessObjects;

namespace MemberManager.Interfaces
{
    public interface IMemberRepo
    {
        IQueryable<Member> Get();

        Member GetMember(int id);
    }
}
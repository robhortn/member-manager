using System.Linq;
using MemberManager.BusinessObjects;

namespace MemberManager.Data.Interface
{
    public interface IMemberRepo
    {
        IQueryable<BusinessObjects.Member> Get();

        Member GetMember(int id);
    }
}
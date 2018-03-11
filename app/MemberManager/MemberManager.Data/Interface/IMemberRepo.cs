using System.Linq;

namespace MemberManager.Data.Interface
{
    public interface IMemberRepo
    {
        IQueryable<BusinessObjects.Member> Get();

        BusinessObjects.Member GetMember(int id);
    }
}
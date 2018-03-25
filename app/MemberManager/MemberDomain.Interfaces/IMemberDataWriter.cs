using MemberManager.BusinessObjects;

namespace MemberManager.Interfaces
{
    public interface IMemberDataWriter
    {
        int Save(Member member);
        bool Delete(int id);
    }
}

using MemberManager.Data.EF;

namespace MemberManager.Data.Interface
{
    public interface IMemberDataWriter
    {
        int Save(Member member);
        bool Delete(int id);
    }
}

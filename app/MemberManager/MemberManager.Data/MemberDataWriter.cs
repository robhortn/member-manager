using MemberManager.Data.EF;
using MemberManager.Data.Interface;

namespace MemberManager.Data
{
    public class MemberDataWriter : IMemberDataWriter
    {
        public bool Delete(int id)
        {
            return true;
        }

        public int Save(Member member)
        {
            return 1;
        }
    }
}
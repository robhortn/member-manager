using MemberManager.Data.EF;

namespace MemberManager.Data
{
    public abstract class RepoBase
    {
        public MemberManagerEntities MemberContext { get; } = new MemberManagerEntities();
    }
}

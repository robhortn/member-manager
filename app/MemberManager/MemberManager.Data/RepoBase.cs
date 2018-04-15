using MemberManager.Data.EF;

namespace MemberManager.Data
{
    public abstract class RepoBase
    {
        readonly MemberManagerEntities _contextProvider = new MemberManagerEntities();

        public MemberManagerEntities MemberContext
        {
            get { return _contextProvider; }
        }
    }
}

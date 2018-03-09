using MemberManager.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManager.Data.Interface
{
    public interface IMemberRepo
    {
        string DbCall();
        IQueryable<Member> Get();
        Member GetMember(int id);
    }
}

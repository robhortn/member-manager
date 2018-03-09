using MemberManager.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManager.Domain.Interfaces
{
    public interface IMemberDomain
    {
        int Save(Member member);
        bool Delete(int id);
        string DbCall();
        IQueryable<Member> Get();
        Member GetMember(int id);
    }
}

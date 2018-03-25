using MemberManager.Data.Interface;
using MemberManager.Data.Helpers;
using MemberManager.BusinessObjects;

using System;
using System.Linq;

namespace MemberManager.Data
{
    public class MemberRepo : IMemberRepo
    {
        IQueryable<Member> IMemberRepo.Get()
        {
            throw new NotImplementedException();
        }

        Member IMemberRepo.GetMember(int id)
        {
            EF.Member objMember = new EF.Member();
            objMember.Id = 1;

            Member results = Mappings.MapMember(objMember);
            return results;
        }
    }
}
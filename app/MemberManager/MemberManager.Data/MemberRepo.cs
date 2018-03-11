using MemberManager.Data.EF;
using MemberManager.Data.Interface;
using MemberManager.Data.Helpers;

using System;
using System.Linq;

namespace MemberManager.Data
{
    public class MemberRepo : IMemberRepo
    {
        IQueryable<BusinessObjects.Member> IMemberRepo.Get()
        {
            throw new NotImplementedException();
        }

        BusinessObjects.Member IMemberRepo.GetMember(int id)
        {
            Member objMember = new Member();
            objMember.Id = 1;

            BusinessObjects.Member results = Mappings.MapMember(objMember);
            return results;
        }
    }
}
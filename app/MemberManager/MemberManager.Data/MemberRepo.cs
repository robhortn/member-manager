using MemberManager.Data.Helpers;
using MemberManager.BusinessObjects;
using MemberManager.Interfaces;

using System;
using System.Linq;
using System.Collections.Generic;

namespace MemberManager.Data
{
    public class MemberRepo : IMemberRepo
    {
        private List<EF.Member> _db = null;

        public MemberRepo()
        {
            _db = new List<EF.Member>();
        }
    
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
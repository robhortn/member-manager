using MemberManager.Data.Helpers;
using MemberManager.BusinessObjects;
using MemberManager.Interfaces;
using MemberManager.BusinessObjects.Queries;

using System;
using System.Linq;
using System.Collections.Generic;
using MemberManager.Data.EF;

namespace MemberManager.Data
{
    public class MemberRepo : RepoBase, IMemberRepo
    {
        private List<EF.Member> _db = null;

        public MemberRepo()
        {
            _db = new List<EF.Member>();
        }

        public ICollection<BusinessObjects.Member> Get(MemberQueryParameter query)
        {
            var queryable = GetBaseQuery();
            queryable = ApplyQuery(query, queryable);
            var results = queryable.AsEnumerable().Select(x => Mappings.MapMember(x)).ToList();
            return results;
        }

        public BusinessObjects.Member GetMember(int id)
        {
            var findResult = GetMemberById(id);
            if (findResult == null) return new BusinessObjects.Member { Id = 0 };

            BusinessObjects.Member results = Mappings.MapMember(findResult);
            return results;
        }
        public bool Delete(int id)
        {
            var findResult = GetMemberById(id);
            if (findResult == null) return false;

            findResult.Active = false;
            MemberContext.SaveChanges();

            return true;
        }

        public int Save(BusinessObjects.Member member)
        {
            EF.Member memberInfoToSave = null;

            // Go get the existing record, if there is one, so we can update it.
            if (member.Id > 0)
            {
                memberInfoToSave = GetMemberById(member.Id);
            }

            // If we found no existing record or we had no Id at all, then we default to adding a new record.
            if (memberInfoToSave == null)
            {
                memberInfoToSave = new EF.Member();
                MemberContext.Members.Add(memberInfoToSave);
                memberInfoToSave.CreatedDate = DateTime.Now;
            }

            memberInfoToSave.FirstName = member.FirstName;
            memberInfoToSave.LastModifiedDate = DateTime.Now;
            memberInfoToSave.Active = member.Active;
            memberInfoToSave.DateOfBirth = member.DateOfBirth;
            memberInfoToSave.EmailAddress = member.EmailAddress;
            memberInfoToSave.LastName = member.LastName;
            memberInfoToSave.PhoneNumber = member.PhoneNumber;
            memberInfoToSave.UserName = member.UserName;

            MemberContext.SaveChanges();

            return memberInfoToSave.Id;
        }

        private EF.Member GetMemberById(int id)
        {
            return MemberContext.Members.Find(id);
        }

        private IQueryable<EF.Member> GetBaseQuery()
        {
            return MemberContext.Members.Where(m => m.Active == true).AsQueryable();
        }

        private IQueryable<EF.Member> ApplyQuery(MemberQueryParameter query, IQueryable<EF.Member> queryable)
        {
            if (!string.IsNullOrWhiteSpace(query.FirstName))
            {
                queryable = queryable.Where(c => c.FirstName.Contains(query.FirstName));
            }

            return queryable;
        }

    }
}
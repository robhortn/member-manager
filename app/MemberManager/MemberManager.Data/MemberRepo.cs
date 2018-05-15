using MemberManager.Data.Helpers;
using MemberManager.BusinessObjects;
using MemberManager.Interfaces;
using MemberManager.BusinessObjects.Queries;

using System;
using System.Linq;
using System.Collections.Generic;

namespace MemberManager.Data
{
    public class MemberRepo : RepoBase, IMemberRepo
    {
        private List<EF.Member> _db = null;

        public MemberRepo()
        {
            _db = new List<EF.Member>();
        }

        public ICollection<Member> Get(MemberQueryParameter query)
        {
            if (query == null)
            {
                query = new MemberQueryParameter { Id = 0 };
            }

            var queryable = GetBaseQuery();
            queryable = ApplyQuery(query, queryable);
            var results = ConvertSearchResults(queryable);
            return results;
        }

        public Member GetMember(int id)
        {
            var findResult = GetMemberById(id);
            if (findResult == null)
            {
                return new Member { Id = 0 };
            }

            Member results = Mappings.MapMember(findResult);
            return results;
        }
        public bool Delete(int id)
        {
            var findResult = GetMemberById(id);
            if (findResult == null)
            {
                return false;
            }

            findResult.Active = false;
            MemberContext.SaveChanges();

            return true;
        }

        public int Save(Member member)
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
            if (query.Id > 0)
            {
                queryable = queryable.Where(q => q.Id == query.Id);
            }

            if (!string.IsNullOrWhiteSpace(query.UserName))
            {
                queryable = queryable.Where(q => q.UserName.Contains(query.UserName));
            }

            if (!string.IsNullOrWhiteSpace(query.FirstName))
            {
                queryable = queryable.Where(q => q.FirstName.Contains(query.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(query.LastName))
            {
                queryable = queryable.Where(q => q.LastName.Contains(query.LastName));
            }

            if (!string.IsNullOrWhiteSpace(query.EmailAddress))
            {
                queryable = queryable.Where(q => q.EmailAddress.Contains(query.EmailAddress));
            }

            if (!string.IsNullOrWhiteSpace(query.PhoneNumber))
            {
                queryable = queryable.Where(q => q.PhoneNumber.Contains(query.PhoneNumber));
            }

            if (query.CreatedDate != null)
            {
                queryable = queryable.Where(q => q.CreatedDate == query.CreatedDate);
            }

            if (query.Active != null)
            {
                queryable = queryable.Where(q => q.Active == query.Active);
            }

            if (query.DateOfBirth != null)
            {
                queryable = queryable.Where(q => q.DateOfBirth == query.DateOfBirth);
            }

            if (query.LastModifiedDate != null)
            {
                queryable = queryable.Where(q => q.LastModifiedDate == query.LastModifiedDate);
            }

            return queryable;
        }

        private static List<Member> ConvertSearchResults(IQueryable<EF.Member> queryable)
        {
            return queryable.AsEnumerable().Select(x => Mappings.MapMember(x)).ToList();
        }
    }
}
using MemberManager.Data.Helpers;
using MemberManager.BusinessObjects;
using MemberManager.Interfaces;

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

        public ICollection<Member> Get()
        {
            var results = MemberContext.Members.Select(x => new Member {
                Active = x.Active,
                CreatedDate = x.CreatedDate,
                DateOfBirth = x.DateOfBirth,
                EmailAddress = x.EmailAddress,
                FirstName = x.FirstName,
                Id = x.Id,
                LastModifiedDate = x.LastModifiedDate,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
                UserName = x.UserName
            }).ToList();

            return results;
        }

        public Member GetMember(int id)
        {
            var findResult = GetMemberById(id);
            if (findResult == null) return new Member { Id = 0 };

            Member results = Mappings.MapMember(findResult);
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
            memberInfoToSave.DateOfBirth = DateTime.Now;
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
    }
}
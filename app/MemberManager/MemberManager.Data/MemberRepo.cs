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

        public List<Member> Get()
        {
            List<Member> results = new List<Member>();
            foreach (var item in _db)
            {
                var addItem = Mappings.MapMember(item);
                results.Add(addItem);
            }
            return results;
        }

        public Member GetMember(int id)
        {
            var findResult = _db.Find(x => x.Id == id);
            if (findResult == null) return new Member { Id = 0 };

            Member results = Mappings.MapMember(findResult);
            return results;
        }
        public bool Delete(int id)
        {
            var resultIndex = _db.FindIndex(x => x.Id == id);
            if (resultIndex == -1) return false;

            _db.RemoveAt(resultIndex);
            return true;
        }

        public int Save(Member member)
        {
            var newMember = Mappings.MapMember(member);
            newMember.Id = GetNextId();
            _db.Add(newMember);
            return newMember.Id;
        }

        private int GetNextId()
        {
            return _db.Count + 1;
        }
    }
}
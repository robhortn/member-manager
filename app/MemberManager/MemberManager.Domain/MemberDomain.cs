using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.BusinessObjects;
using MemberManager.Data.Interface;
using MemberManager.Domain.Interfaces;

namespace MemberManager.Domain
{
    public class MemberDomain : IMemberDomain
    {
        private IMemberDataWriter _dw;
        private IMemberRepo _repo;

        public MemberDomain(IMemberDataWriter dw, IMemberRepo repo)
        {
            _dw = dw;
            _repo = repo;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Member> Get()
        {
            throw new NotImplementedException();
        }

        public Member GetMember(int id)
        {
            return _repo.GetMember(id);
        }

        public int Save(Member member)
        {
            throw new NotImplementedException();
        }
    }
}

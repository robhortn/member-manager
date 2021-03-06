﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberManager.Data.EF;
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

        public string DbCall()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Save(Member member)
        {
            throw new NotImplementedException();
        }

        public string TestCall()
        {
            return "Hey from Domain.Class1.TestCall()";
        }
    }
}

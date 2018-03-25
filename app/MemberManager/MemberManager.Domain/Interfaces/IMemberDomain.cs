﻿using MemberManager.BusinessObjects;
using System.Linq;

namespace MemberManager.Domain.Interfaces
{
    public interface IMemberDomain
    {
        bool Delete(int id);

        IQueryable<Member> Get();

        Member GetMember(int id);

        int Save(Member member);
    }
}
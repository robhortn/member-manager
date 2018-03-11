using MemberManager.Data.EF;
using System;

namespace MemberManager.Data.Helpers
{
    public static class Mappings
    {
        public static BusinessObjects.Member MapMember(Member member)
        {
            if (member == null) throw new NullReferenceException("member is null in params list");

            try
            {
                BusinessObjects.Member objMember = new BusinessObjects.Member();
                objMember.Id = member.Id;

                return objMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
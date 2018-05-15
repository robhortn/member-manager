using MemberManager.Data.EF;
using System;

namespace MemberManager.Data.Helpers
{
    public static class Mappings
    {
        public static BusinessObjects.Member MapMember(Member member)
        {
            if (member == null)
            {
                throw new NullReferenceException("member is null in params list");
            }

            try
            {
                BusinessObjects.Member objMember = new BusinessObjects.Member();
                objMember.Id = member.Id;
                objMember.Active = member.Active;
                objMember.CreatedDate = member.CreatedDate;
                objMember.DateOfBirth = member.DateOfBirth;
                objMember.EmailAddress = member.EmailAddress;
                objMember.UserName = member.UserName;
                objMember.FirstName = member.FirstName;
                objMember.LastName = member.LastName;
                objMember.LastModifiedDate = member.LastModifiedDate;
                objMember.PhoneNumber = member.PhoneNumber;

                return objMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Member MapMember(BusinessObjects.Member member)
        {
            if (member == null)
            {
                throw new NullReferenceException("member is null in params list");
            }

            try
            {
                Member objMember = new Member();
                objMember.Id = member.Id;
                objMember.UserName = member.UserName;
                objMember.Active = member.Active;
                objMember.CreatedDate = member.CreatedDate;
                objMember.DateOfBirth = member.DateOfBirth;
                objMember.EmailAddress = member.EmailAddress;
                objMember.FirstName = member.FirstName;
                objMember.LastName = member.LastName;
                objMember.LastModifiedDate = member.LastModifiedDate;
                objMember.PhoneNumber = member.PhoneNumber;

                return objMember;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
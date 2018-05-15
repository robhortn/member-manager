using System;

namespace MemberDomain.BusinessObjects.Queries
{
    public class MemberQueryParameter
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public override string ToString()
        {
            var message = string.Empty;
            message += (Id > 0) ? " IDs => " + Id + "; " : null;
            message += (!string.IsNullOrEmpty(UserName)) ? " Username => " + UserName + "; " : null;
            message += (!string.IsNullOrEmpty(FirstName)) ? " FirstName => " + FirstName + "; " : null;
            message += (!string.IsNullOrEmpty(LastName)) ? " LastName => " + LastName + "; " : null;
            message += (!string.IsNullOrEmpty(EmailAddress)) ? " EmailAddress => " + EmailAddress + "; " : null;
            message += (!string.IsNullOrEmpty(DateOfBirth?.ToShortDateString())) ? " Birth Date => " + DateOfBirth?.ToShortDateString() + "; " : null;
            message += (!string.IsNullOrEmpty(PhoneNumber)) ? " PhoneNumber => " + PhoneNumber + "; " : null;
            message += (!string.IsNullOrEmpty(DateOfBirth?.ToShortDateString())) ? " Birth Date => " + DateOfBirth?.ToShortDateString() + "; " : null;
            message += (!string.IsNullOrEmpty(CreatedDate?.ToShortDateString())) ? " Creation Date => " + CreatedDate?.ToShortDateString() + "; " : null;
            message += (!string.IsNullOrEmpty(LastModifiedDate?.ToShortDateString())) ? " Last Modified Date => " + LastModifiedDate?.ToShortDateString() + "; " : null;
            message += (Active != null) ? " Active => " + Active + "; " : null;

            return message;
        }
    }
}

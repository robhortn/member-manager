using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManager.BusinessObjects
{
    public class Member
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public bool Active { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
    }
}

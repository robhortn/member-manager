using MemberManager.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManager.Data
{
    public class MemberRepo : IMemberRepo
    {
        public string DbCall()
        {
            return "Hey from DbCall in MemberRepo!";
        }
    }
}

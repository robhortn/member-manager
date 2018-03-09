using MemberManager.Data.EF;
using MemberManager.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberManager.Data
{
    public class MemberDataWriter : IMemberDataWriter
    {
        public bool Delete(int id)
        {
            return true;
        }

        public int Save(Member member)
        {
            return 1;
        }
    }
}

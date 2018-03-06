using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemberManager.Interface;

namespace MemberManager
{
    public class Test : ITest
    {
        public string TestCall() {
            return "Hey from TestCall()";
        }
    }
}
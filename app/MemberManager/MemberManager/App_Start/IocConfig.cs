using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemberManager.DependencyInjection;

namespace MemberManager
{
    public class IocConfig
    {
        public static void Load() {
            var bindings = new IocBindings();
            bindings.Load();
        }
    }
}
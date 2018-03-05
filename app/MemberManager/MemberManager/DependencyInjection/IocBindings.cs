using Ninject.Modules;
using MemberManager.Api;
using MemberManager.Interface;

namespace MemberManager.DependencyInjection
{
    public class IocBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberController>().To<MemberController>();
        }
    }
}
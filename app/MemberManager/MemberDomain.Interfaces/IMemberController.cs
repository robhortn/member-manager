using System.Web.Http;

namespace MemberManager.Interfaces
{
    public interface IMemberController
    {
        IHttpActionResult Get();
    }
}
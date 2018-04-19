using MemberManager.BusinessObjects;
using MemberManager.BusinessObjects.Queries;
using MemberManager.Interfaces;
using System.Web.Http;

namespace MemberManager.Api
{
    public class MemberController : BaseController
    {
        private IMemberDomain _memberDomain;

        public MemberController(IMemberDomain memberDomain)
        {
            _memberDomain = memberDomain;
        }

        // GET api/<controller>
        public IHttpActionResult Get([FromBody] MemberQueryParameter query)
        {
            var response = _memberDomain.Get(query);
            return Ok(response);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            var response = _memberDomain.GetMember(id);
            return Ok(response);
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody]Member member)
        {
            var response = _memberDomain.Save(member);
            return Ok(response);
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var response = _memberDomain.Delete(id);
            return Ok(response);
        }
    }
}
using MemberManager.BusinessObjects;
using MemberManager.BusinessObjects.Queries;
using MemberManager.Interfaces;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MemberManager.Api
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MemberController : BaseController
    {
        private IMemberDomain _memberDomain;

        public MemberController(IMemberDomain memberDomain)
        {
            _memberDomain = memberDomain;
        }

        [HttpPost]
        [Route("member/find")]
        public IHttpActionResult Members([FromBody] MemberQueryParameter query)
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

        //[HttpPost]
        //[Route("member/save")]
        //public IHttpActionResult Post([FromBody]Member member)
        //{
        //    var response = _memberDomain.Save(member);
        //    return Ok(response);
        //}

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var response = _memberDomain.Delete(id);
            return Ok(response);
        }
    }
}
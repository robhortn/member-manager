﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MemberManager.Interface;
using MemberManager.Domain.Interfaces;

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
        public IHttpActionResult Get()
        {
            var response = _memberDomain.GetMember(1);
            return Ok(response);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
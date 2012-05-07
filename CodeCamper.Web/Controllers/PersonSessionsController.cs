﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CodeCamper.Data;
using CodeCamper.Model;

namespace CodeCamper.Web.Controllers.Controllers
{
    public class PersonSessionsController : ApiControllerBase
    {
        public PersonSessionsController(ICodeCamperRepository repository)
        {
            Repository = repository;
        }
       
        // GET: api/events/sessions
        //[ActionName("personsessions")]
        //public IEnumerable<PersonSession> GetPersonSessions()
        public HttpResponseMessage<IEnumerable<PersonSession>> GetPersonSessions()
        {
            return new HttpResponseMessage<IEnumerable<PersonSession>>(HttpStatusCode.Forbidden); //security violation
            //return new HttpResponseMessage(HttpStatusCode.BadRequest);
            //return Repository.PersonSessions().OrderBy(ps => ps.SessionId).ToList();
        }

        public IEnumerable<PersonSession> GetPersonSessionsByPersonId(int id)
        {
            return Repository.PersonSessionsByPersonId(id).OrderBy(ps => ps.SessionId).ToList();
        }
        
        //// GET /api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST /api/<controller>
        //public void Post(string value)
        //{
        //}

        //// PUT /api/<controller>/5
        //public void Put(int id, string value)
        //{
        //}

        //// DELETE /api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}
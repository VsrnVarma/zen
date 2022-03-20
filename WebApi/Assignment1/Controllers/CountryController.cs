using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Assignment1.Models;

namespace Assignment1.Controllers
{
    [RoutePrefix("api/country")]
    public class CountryController : ApiController
    {
        static List<Country> cList = new List<Country>()
        {
            new Country{Id=1,Name="India",Capital="New Delhi"},
            new Country{Id=2,Name="USA",Capital="Washington DC"},
            new Country{Id=3,Name="Japan",Capital="Tokyo"},
        };

        //Get
        //[Route("countrylist")]
        public HttpResponseMessage GetPersonList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, cList);
            return response;
        }

        public HttpResponseMessage Post([FromBody] Country c)
        {
            cList.Add(c);
            HttpResponseMessage res = Request.CreateResponse(HttpStatusCode.OK, cList);
            return res;
        }

        public IHttpActionResult Delete(int id)
        {
            cList.RemoveAt(id - 1);
            return Ok();
        }

        public IHttpActionResult Put(int id,[FromBody] Country c)
        {
            cList[id - 1] = c;
            return Ok();
        }
    }
}

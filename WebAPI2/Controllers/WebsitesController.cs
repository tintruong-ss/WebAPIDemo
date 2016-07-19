﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using WebAPI2.ActionFilters;

namespace WebAPI.Controllers
{
    public class Website
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/Websites")]
    //[Authorize]
    public class WebsitesController : ApiController
    {
        Website[] websites = new Website[]
        {
            new Website { Id = 1, Name = "BirdMMO.com", Description = "Bird Flapping Game For Everybody"},
            new Website { Id = 2, Name = "SpiderMMO.com", Description = "Spider Versus Spider Death Match"},
            new Website { Id = 3, Name = "LiveAutoWheel.com", Description = "Random Number Generator"},
            new Website { Id = 4, Name = "SeanWasEre.com", Description = "A Blog of Trivial Things"}
        };

        // GET api/Websites 
        public IEnumerable<Website> Get()
        {
            return websites;
        }

        // GET api/Websites/5 
        public Website Get(int id)
        {
            try
            {
                return websites[id];
            }
            catch (Exception e)
            {
                return new Website();
            }
        }

        [MyExceptionFilter]
        // POST api/values 
        public Website Post([FromBody]Website value)
        {
            Console.WriteLine("Post method called with value = " + value);
            value.Id = 100;
            value.Name = "DavidTruong.com";
            value.Description = "David Site";
            return value;
        }

        [Route("PostWithNoExceptionFilter")]
        // POST api/values 
        public Website PostNoExceptionFilter([FromBody]Website value)
        {
            Console.WriteLine("Post method called with value = " + value);
            value.Id = 100;
            value.Name = "DavidTruong.com";
            value.Description = "David Site";
            return value;
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
            Console.WriteLine("Put method called with value = " + value);
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            Console.WriteLine("Delete method called with id = " + id);
        }

        [Route("{id:int}/details")]
        public Website GetTest(int id)
        {
            return websites[id];
        }
    }
}

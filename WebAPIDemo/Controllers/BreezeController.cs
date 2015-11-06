﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.WebApi2;
using System.Web.Http;
using WebAPIDemo.Models;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;

namespace WebAPIDemo.Controllers
{
    [BreezeController]
    public class BreezeController : ApiController
    {
        private readonly IRepository _repo;

        public BreezeController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public string Metadata()
        {
            return _repo.Metadata;
        }
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repo.SaveChanges(saveBundle);
        }
        [HttpGet]
        public IQueryable<Book> Books()
        {
            return _repo.Books();
        }
        [HttpGet]
        public IQueryable<Order> Orders()
        {
            return _repo.Orders();
        }
    }
}
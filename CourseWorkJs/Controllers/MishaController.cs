﻿using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseWorkJs.Controllers
{
    public class MishaController : Controller
    {
        // GET: Misha
        DAL.IDAL ctx = new EDAL();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ContentResult GetLast5Transactions()
        {
            var list = ctx.Get5Transactions();
            Response.AppendCookie(new HttpCookie("Fff", "ffefe"));
            return Content(JsonConvert.SerializeObject(list).ToString(), "application/json");
        }
        [HttpPost]
        public ContentResult Register(string login, string password, string email)
        {
           bool l=  ctx.Register(login, password, email);
            return Content(JsonConvert.SerializeObject(l), "application/json");
        }
        [HttpPost]
        public ContentResult Login(string email, string password)
        {
            bool l = ctx.Login(email, password);
            return Content(JsonConvert.SerializeObject(l), "application/json");
        }
        [HttpGet]
        public ContentResult GetCourse(string shortname)
        {

        }

    }
}
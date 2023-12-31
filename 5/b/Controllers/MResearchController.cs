﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace b.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        [HttpGet]
        [Route("{n:int}/{str}")]
        public ActionResult M01(int n, string str)
        {
            return Content($"{Request.HttpMethod}:M01:/{n}/{str}");
        }

        [AcceptVerbs("post", "get")]
        [Route("{b:bool}/{letters:alpha}")]
        public ActionResult M02(bool b, string letters)
        {
            return Content($"{Request.HttpMethod}:M02:/{b}/{letters}");
        }

        [AcceptVerbs("delete", "get")]
        [Route("{f:float}/{str:length(2,5)}")]
        public ActionResult M03(float f, string str)
        {
            return Content($"{Request.HttpMethod}:M03:/{f}/{str}");
        }

        [HttpPut]
        [Route("{letters:alpha:length(3,4)}/{n:int:range(100,200)}")]
        public ActionResult M04(string letters, int n)
        {
            return Content($"{Request.HttpMethod}:M04:/{letters}/{n}");
        }

        [HttpPost]
        [Route(@"{mail:regex(^[\w-\.]+@([\w-]+\.)+[\w-]+$)}")]
        public ActionResult M05(string mail)
        {
            return Content($"{Request.HttpMethod}:M05/{mail.Replace(',', '.')}");
        }
    }
}
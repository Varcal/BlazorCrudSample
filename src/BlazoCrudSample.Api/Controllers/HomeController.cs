﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazoCrudSample.Api.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public string Get()
        {
            return "Api running";
        }
    }
}
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service2.Controllers
{
    /// <summary>
    /// 测试 Control
    /// </summary>
   [Route("[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 获取Service1 检查结果
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            return "This is Service2 Get!";
        }
    }
}

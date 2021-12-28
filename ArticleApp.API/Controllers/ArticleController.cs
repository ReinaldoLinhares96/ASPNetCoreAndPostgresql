using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ArticleApp.API.Data;
using ArticleApp.API.Models;
using ArticleApp.API.Util;

namespace ArticleApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController: ControllerBase
    {
        private DataContext _context = null;

        public ArticleController(DataContext context){
            _context = context;
        }

        [HttpGet]
        public ActionResult GetAlls(){
            return Ok(_context.Articles.Select(s=>StringProcessor.ToUpperCase(s.Name)).ToList());
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class setDocumentStatus : ControllerBase
    {
        
        // PUT api/<setDocumentStatus>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StatusEnum value)
        {
            //id==UserDocumentID

        }

        
    }
}

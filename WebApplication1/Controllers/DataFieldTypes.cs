using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFieldTypes : ControllerBase
    {
        // GET: api/<DataFieldTypes>
        List<string> types = new List<string>();

       [HttpGet]
        public string Get()
        {
           
            types.Add("TextBox");
            types.Add("MaskEdit");
            types.Add("ComboBox");
            string str = JsonConvert.SerializeObject(types);
            return str;
        }


        // POST api/<DataFieldTypes>
        [HttpPost]
        public void Post([FromBody] string value)
        {
         
            types.Add(value);
        }

        // PUT api/<DataFieldTypes>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            types[id] = value;
        }

        // DELETE api/<DataFieldTypes>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            String str = types[id];
            types.Remove(str);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class documentTemplates : ControllerBase
    {
        List<DocumentTemplateModel> documents = new List<DocumentTemplateModel>();
        // GET: api/<documentManager>
       

        // GET api/<documentManager>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            DocumentTemplateModel d = documents[id];
            string str = JsonConvert.SerializeObject(d);
            return str;
        }

        // POST api/<documentManager>
        [HttpPost]
        public void Post([FromBody] DocumentTemplateModel value)
        {
            documents.Add(value);
        }

        // PUT api/<documentManager>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DocumentTemplateModel value)
        {
            DocumentTemplateModel newDoc = value;
            DocumentTemplateModel oldDoc = documents[id];
            oldDoc.Caption = newDoc.Caption;
            ///Verification:  can remove?
            ///if yes
            oldDoc.Fields.Clear();
            foreach (DocumentFieldModel df in newDoc.Fields)
            {
                DocumentFieldModel df1 = new DocumentFieldModel();
                df1.Name = df.Name;
                df1.DataType = df.DataType;
                oldDoc.Fields.Add(df1);
            }
        }

        // DELETE api/<documentManager>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DocumentTemplateModel d = documents[id];
            //if can remove
            documents.Remove(d);
        }
    }
}

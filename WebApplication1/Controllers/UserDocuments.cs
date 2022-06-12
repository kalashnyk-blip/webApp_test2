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
    public class UserDocuments : ControllerBase
    {/// <summary>
    /// list of the user documents
    /// </summary>
       public static List<UserDocumentModel> dataBase = new List<UserDocumentModel>();
        // GET: api/<UserDocuments>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserDocuments>/5
        [HttpGet("{id}")]
        public IEnumerable<UserDocumentModel> Get(int id)
        {
            List<UserDocumentModel> temp = new List<UserDocumentModel>();
            foreach(UserDocumentModel udm in dataBase)
            {
                if (udm.UserID==id)
                {
                    UserDocumentModel u = new UserDocumentModel();
                    u.UserID = udm.UserID;
                    u.documentTemplateID = udm.documentTemplateID;
                    temp.Add(u);
                }
            }
            return temp;
        }

        // POST api/<UserDocuments>
        [HttpPost]
        public void Post([FromBody] UserDocumentModel value)
        {
            dataBase.Add(value);
        }

        // PUT api/<UserDocuments>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserDocumentModel value)
        {
            
            //empty method
        }

        // DELETE api/<UserDocuments>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserDocumentModel udm = dataBase[id];
            dataBase.Remove(udm);
        }
    }
}

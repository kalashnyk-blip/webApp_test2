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
    public class DocumentData : ControllerBase
    {
        public static List<DocumentDataModel> dataBase = new List<DocumentDataModel>();
     
       

        // GET api/<DocumentData>/5
        //BY DOCUMENT ID
        [HttpGet("{id}")]
        public DocumentDataModel Get(int id)
        {
            //    id=DocumentID 
            DocumentDataModel D = dataBase.Where(_ => _.UserDocumentID == id).FirstOrDefault();
            return D;
        }

        // POST api/<DocumentData>
        bool isExist(DocumentDataModel value)
        {
            bool result = false;
            foreach (DocumentDataModel v in dataBase)
            {
                if (v.ID == value.ID)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        [HttpPost]
        public void Post([FromBody] DocumentDataModel value)
        {
            if (!isExist(value))
            {
                dataBase.Add(value);
            }

        }

        // PUT api/<DocumentData>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DocumentDataModel value)
        {
            
            DocumentDataModel old = dataBase[id];
            
            foreach(DocumentFieldModel f in old.Fields)
            {
                f.Value = value.Fields.Where(_ => _.Name == f.Name);
            }
            
        }

        // DELETE api/<DocumentData>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DocumentDataModel d = dataBase[id];
            dataBase.Remove(d);
        }
    }
}

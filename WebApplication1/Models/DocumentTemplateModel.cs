using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DocumentTemplateModel
    {
        public string Caption { get; set; }
        public List<DocumentFieldModel> Fields { get; set; }
        public int ID { get; set; }
        public DocumentTemplateModel()
        {
            Fields = new List<DocumentFieldModel>();
        }
    }
}

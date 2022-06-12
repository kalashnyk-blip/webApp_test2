using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DocumentDataModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int documentTemplateID  { get; set; }
        public int UserDocumentID { get; set; }//=UserDocumentModel.id
        public List<DocumentFieldModel> Fields { get; set; }
       
    }
   
}

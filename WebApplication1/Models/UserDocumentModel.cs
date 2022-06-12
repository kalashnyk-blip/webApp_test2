using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserDocumentModel
    {
        public int UserID { get; set; }
        public int documentTemplateID { get; set; }
        public int ID { get; set; }
        public StatusEnum Status { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DocumentFieldModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public object Value { get; set; }

    }
}

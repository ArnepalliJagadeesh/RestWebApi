using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApiModels
{
    public class product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public int IsDiscontinued { get; set; }
    }
}

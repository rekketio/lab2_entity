using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProj.Data
{
    public class Contract
    {
        public int Id { get; set; }
        public List<Car> Cars { get; set; }
        public string BeginDate { get; set; }
        public int ContractLong { get; set; }
        public int Cost { get; set; }
        public string ReturnDate { get; set; }
        public string Notes { get; set; }


    }
}

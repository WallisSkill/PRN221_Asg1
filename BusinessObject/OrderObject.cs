using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    
    public class OrderObject
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public override string? ToString()
        {
            return $"{OrderId} {MemberId} {OrderDate} {RequiredDate} {ShippedDate} {Freight}";
        }
    }
}

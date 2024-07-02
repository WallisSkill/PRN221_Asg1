using BusinessLogic;
using DataAccess.Models;
using DataAccess.Repository.Interface;
using Lombok.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    [RequiredArgsConstructor]
    public partial class OrderRepository : IOrderRepository
    {
       private readonly PRN221_asg1Context _context;
       public List<Order> getOrders()
        {
            var result= _context.Orders.ToList();
            return result;
        }
    }
}

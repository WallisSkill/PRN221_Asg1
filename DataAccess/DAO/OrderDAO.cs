using BusinessLogic;
using DataAccess.Models;
using DataAccess.Repository.Interface;
using Lombok.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    [RequiredArgsConstructor]
    public partial class OrderDAO
    {
        private readonly IOrderRepository _orderRepository;
        public List<Order> getOrders()
        {

           return _orderRepository.getOrders();
        }
    }
}

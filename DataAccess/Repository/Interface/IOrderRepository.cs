using BusinessLogic;
using DataAccess.Models;

namespace DataAccess.Repository.Interface
{
    public interface IOrderRepository
    {
       public List<Order> getOrders();
    }
}

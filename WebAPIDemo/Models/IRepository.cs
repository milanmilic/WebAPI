using System.Linq;

namespace WebAPIDemo.Models
{
    public interface IRepository
    {
        IQueryable<Order> GetAllOrders();
        IQueryable<Order> GetAllOrderWithDetails();
        Order GetOrder(int id);
    }
}
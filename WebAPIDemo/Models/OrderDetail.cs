namespace WebAPIDemo.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }

        //navigacija
        public virtual Order Order { get; set; }
        public virtual Book Book { get; set; }
    }
}
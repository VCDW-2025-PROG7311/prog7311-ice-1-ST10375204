
namespace orderServ.Services
{
    public class OrderService
    {
        private Random random;

       
        public OrderService()
        {
            random = new Random();
        }

       
        public int CreateOrder()
        {
           
            int orderID = random.Next(1, 10001);
            return orderID;  
        }
    }
}



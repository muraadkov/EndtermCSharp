namespace FoodOrder.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string MealName { get; set; }
        public int Quantity { get; set; }
        public int Sum { get; set; }

    }
}

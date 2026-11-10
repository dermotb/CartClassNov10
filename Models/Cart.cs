namespace Shop.Models
{
    public class Cart
    {
        private List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        public void AddItem(Item _item)
        {
            CartItem match = items.FirstOrDefault(i=>i.code==_item.code);
            if (match==null)
            {
                items.Add(new CartItem(){code=_item.code, Description=_item.Description, Price=_item.Price, Quantity=1});
            }
            else
            {
                match.Quantity++;
            }
        }

        public double CalculateTotalPrice()
        {
            return items.Sum(i=>i.Price * i.Quantity);
        }
    }
}
using System.Collections.Generic;
public class OrderItems
{
    public string fname;
    public int quantity;
    public int price;
    public int tableno;
    public string time;
    public void add_order_in_list(List<Item> items,int index,int quantity,List<OrderItems> orders)
    {
        int addin = -1;
        OrderItems order=new OrderItems();
        for(int i = 0; i < items.Count; i++)
        {
            if(items[i].itemid == index)
            {   
                if(items[i].itemid >= quantity)
                {
                    addin = i;
                    items[addin].stock = items[addin].stock - quantity;
                    break;
                }
                SSTools.ShowMessage("Out of Stock", SSTools.Position.bottom, SSTools.Time.twoSecond);
                return;
            }
        }
        for(int i = 0; i < orders.Count; i++)
        {
            if (addin != -1 && orders[i].fname == items[addin].fname)
            {
                orders[i].quantity = orders[i].quantity + quantity;
                return;
            }
        }
        order.fname = items[addin].fname;
        order.quantity = quantity;
        order.price = items[addin].price;
        orders.Add(order);
    }
}

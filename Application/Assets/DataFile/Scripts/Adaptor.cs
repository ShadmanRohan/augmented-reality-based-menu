using UnityEngine;
using System.Collections.Generic;
using Proyecto26;
//DECLARE CLASS/INTERFACE STRUCTURE THAT HANDLES SENDING DATA TO THE SERVER
abstract class Adaptor
{
    public abstract void send(List<OrderItems> order_Items,List<Item> items,int tableNo,string time,string linkName);
}
class RESTConnect : Adaptor
{
    private static RESTConnect _instance;
    private RESTConnect() { } 
    public static RESTConnect Instance
    {
        get
        {
            if (null == _instance)
            {
                Debug.Log("first");
                _instance = new RESTConnect();
            }

            return _instance;
        }
    }
    public override void send(List<OrderItems> order_Items,List<Item> items,int tableNo,string time,string linkName)
    {
        for (int i = 0; i < order_Items.Count; i++)
        {
            order_Items[i].tableno = tableNo;
            order_Items[i].time = time;
            Debug.Log(linkName);
            RestClient.Post(linkName + "Order_Items" + ".json", order_Items[i]);
        }
        for (int i = 0; i < items.Count; i++)
        {
            RestClient.Put(linkName + "Item/" + items[i].itemid + ".json", items[i]);
            Debug.Log(items[i].fname + " " + items[i].itemid);
        }
    }
}
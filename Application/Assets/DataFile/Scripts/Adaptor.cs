using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Proyecto26;
using System;
//DECLARE CLASS/INTERFACE STRUCTURE THAT HANDLES SENDING DATA TO THE SERVER
abstract class Adaptor
{
    public abstract void send(List<Order_Items> order_Items,List<Item> items,int tableNo,string time);
}

class RESTConnect : Adaptor
{
    private static RESTConnect _instance;
    private RESTConnect()
    {
        Debug.Log("Instance created");
    }

    public void Log(string message)
    {
        Debug.Log(message);
    }

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
    public override void send(List<Order_Items> order_Items,List<Item> items,int tableNo,string time)
    {
        Order_Items order = new Order_Items();
        for (int i = 0; i < order_Items.Count; i++)
        {
            order = order_Items[i];
            order.time = time;
            order.tableno = tableNo;
            order_Items[i] = order;
            RestClient.Post("https://cse327-ec9ea.firebaseio.com/" + "Order_Items" + ".json", order_Items[i]);
        }
        for (int i = 0; i < items.Count; i++)
        {
            RestClient.Put("https://cse327-ec9ea.firebaseio.com/" + "Item/" + items[i].itemid + ".json", items[i]);
            Debug.Log(items[i].fname + " " + i);
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;
public class AddOrders : Testing
{
    public InputField quatity,tableNo;
    static List<TotalItemTable> totalItems = new List<TotalItemTable>();
    static List<OrderItems> orders = new List<OrderItems>();
    static List<Item> items = new List<Item>();
    GetText getText = new GetText();
    string buttonText,linkName;
    public void get_text(Button btn)
    {
        buttonText = btn.name;
    }
    public void addOrder()
    {
        if (checkQuantity(quatity.text))
        {
            OrderItems order = new OrderItems();
            order.add_order_in_list(items, Convert.ToInt32(buttonText), Convert.ToInt32(quatity.text), orders);
        }
    }
    public void add_in_database()
    {
        if (checkTableNO(totalItems[0].tableno, tableNo.text) && checkOrderListEmpty(orders))
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Adaptor adaptor = RESTConnect.Instance;
            adaptor.send(orders, items, Convert.ToInt32(tableNo.text), time, linkName);
            SSTools.ShowMessage("Order Confirmed", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
    }
    public void get_items_details()
    {
        Debug.Log(totalItems[0].total+" "+totalItems[0].tableno);
        GetAdaptor getAdapter = RESTConnectTwo.Instance;
        for (int i = 0; i < totalItems[0].total; i++)
        {
            getAdapter.getitem(items, (i + 1), linkName);
        }
    }
    public void Start()
    {
        GetAdaptor getAdapter = RESTConnectTwo.Instance;
        linkName = getText.get_link();
        getAdapter.get_total_item(totalItems,linkName);
        Scene newscene = SceneManager.GetActiveScene();
        string scenename = newscene.name;
        if(scenename == "MainScene")
        {
            Invoke("get_items_details", 2);
        }
        if (scenename == "OrderListScene")
        {
            checkOrderList_and_Show(orders);
        }
    }
}
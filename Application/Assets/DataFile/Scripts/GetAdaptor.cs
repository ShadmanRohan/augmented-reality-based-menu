using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
abstract class GetAdaptor
{
    public abstract void getitem(List<Item> items,int itemid,string linkName);
    public abstract void get_total_item(List<TotalItemTable> totalItems,string linkName);
}
class RESTConnectTwo : GetAdaptor
{
    private static RESTConnectTwo _instance;
    private RESTConnectTwo() { }
    public static RESTConnectTwo Instance
    {
        get
        {
            if (null == _instance)
            {
                Debug.Log("first");
                _instance = new RESTConnectTwo();
            }

            return _instance;
        }
    }
    public override void getitem(List<Item> items, int itemid, string linkName)
    {
        RestClient.Get<Item>(linkName+"Item/" + itemid + ".json").Then(response =>
        {
            items.Add(response);
        });
    }
    public override void get_total_item(List<TotalItemTable> totalItems,string linkName)
    {
        RestClient.Get<TotalItemTable>(linkName+ "TotalItems/totalitem" + ".json").Then(response => 
        {
            totalItems.Add(response);
        });
    }
}

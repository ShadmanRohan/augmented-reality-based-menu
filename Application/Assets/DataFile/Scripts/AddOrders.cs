using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Proyecto26;
using System;
public class AddOrders : MonoBehaviour
{
    public InputField quatity;
    public InputField tableNo;
    static List<string> foodName = new List<string>();
    static List<string> foodPrice = new List<string>();
    static List<string> foodQuantity = new List<string>();
    static List<string> itemid = new List<string>();
    static List<Item> items = new List<Item>();
    static List<Order_Items> order_items = new List<Order_Items>();
    public GameObject textPrefab;
    public GameObject textPrefab2;
    public GameObject buttonPrefab;
    string buttonText;
    int toast = 0;
    int scene = 0;
    
    public void get_text(Button btn)
    {
        buttonText = btn.name;
        toast++;
        if (items.Count == 0)
        {
            get_items_from_database(buttonText);
        }
        else
        {
            int flag = 0;
            for(int i = 0; i < itemid.Count; i++)
            {
                if(itemid[i] == buttonText) { flag = 1; break; }
            }
            if (flag == 0)
            {
                get_items_from_database(buttonText);
            }
        }
        Debug.Log("Name: "+buttonText);
    }
    public void addOrder()
    {
        if (toast == 0)
        {
            buttonText = itemid[0];
        }
        Debug.Log(items.Count);
        for(int i=0; i<items.Count; i++)
        {
            Debug.Log(items[i].fname);
            if(itemid[i] == buttonText)
            {
                try
                {
                    int quan = Convert.ToInt32(quatity.text);
                    if (quan < 1)
                    {
                        SSTools.ShowMessage("Quantity Should be Valid", SSTools.Position.top, SSTools.Time.oneSecond);
                        return;
                    }
                    if (items[i].stock >= quan)
                    {
                        Order_Items newor = new Order_Items();
                        newor.fname = items[i].fname;
                        int tprice = Convert.ToInt32(items[i].price) * quan;
                        newor.price = tprice.ToString();
                        newor.quantity = quan;
                        foodName.Add(items[i].fname);
                        foodPrice.Add(items[i].price);
                        foodQuantity.Add(quatity.text);
                        order_items.Add(newor);
                        Item item = items[i];
                        item.stock = item.stock - quan;
                        items[i] = item;
                        SSTools.ShowMessage("Item Added", SSTools.Position.top, SSTools.Time.twoSecond);
                        break;
                    }
                    else
                    {
                        SSTools.ShowMessage("Out of Stock", SSTools.Position.top, SSTools.Time.oneSecond);
                    }
                } catch(Exception e)
                {
                    SSTools.ShowMessage("Invalid Input", SSTools.Position.top, SSTools.Time.oneSecond);
                }
            }
        }
    }

    //Merge together similar food orders and add the quantities
    public void merge_double_object()
    {
        List<Order_Items> orders = new List<Order_Items>();
        orders.Add(order_items[0]);
        for (int i = 1; i < order_items.Count; i++)
        {
            int flag = 0;
            {
                for (int j = 0; j < orders.Count; j++)
                {
                    if (order_items[i].fname == orders[j].fname)
                    {
                        Order_Items newor = new Order_Items();
                        newor = orders[j];
                        int tprice = Convert.ToInt32(newor.price);
                        tprice = tprice + Convert.ToInt32(order_items[i].price);
                        newor.quantity = newor.quantity + order_items[i].quantity;
                        newor.price = tprice.ToString();
                        orders[j] = newor;
                        flag++;
                        break;
                    }
                }
                if (flag == 0)
                {
                    orders.Add(order_items[i]);
                }
            }
        }
        foodName.Clear();
        foodPrice.Clear();
        foodQuantity.Clear();
        order_items.Clear();
        order_items = orders;
        for(int i = 0; i < orders.Count; i++)
        {
            foodName.Add(orders[i].fname);
            foodQuantity.Add(orders[i].quantity.ToString());
            int unitprice = Convert.ToInt32(orders[i].price);
            unitprice = unitprice / orders[i].quantity;
            foodPrice.Add(unitprice.ToString());
        }
    }
    //Send Data to Database
    public void add_in_database()
    {
        if(order_items.Count == 0)
        {
            SSTools.ShowMessage("Place Some Orders First", SSTools.Position.bottom, SSTools.Time.twoSecond);
            return;
        }
        int tablen;
        string time = DateTime.Now.ToString("h:mm:ss tt");
        try
        {
            tablen = Convert.ToInt32(tableNo.text);
        }
        catch (Exception e)
        {
            SSTools.ShowMessage("Must be a Valid Table Number", SSTools.Position.bottom, SSTools.Time.twoSecond);
            return;
        }
        if (tablen < 1 || tablen > 5)
        {
            SSTools.ShowMessage("Invalid Table Number", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        else
        {
            Adapter adapter=RESTConnect.Instance;
            adapter.send(order_items,items,tablen,time);
            SSTools.ShowMessage("Order Confirmed", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
    }
    public void get_items_from_database(string newf)
    {
        RestClient.Get<Item>("https://cse327-ec9ea.firebaseio.com/Item/" + newf + ".json").Then(response =>
        {
            items.Add(response);
            itemid.Add(newf);
        });
    }
    //Start Program
    public void Start()
    {
        Scene newscene = SceneManager.GetActiveScene();
        string scenename = newscene.name;
        if(scenename == "MainScene" )
        {
            get_items_from_database("1");
        }
        if (scenename == "OrderListScene")
        {
            try
            {
                merge_double_object();
            }catch(Exception e)
            {
                SSTools.ShowMessage("Please Place Some Orders First", SSTools.Position.bottom, SSTools.Time.threeSecond);
            }
            int sum = 0;
            for (int i = 0; i < foodName.Count; i++)
            {
                int c1 = 0, c2 = 0;
                GameObject button = (GameObject)Instantiate(buttonPrefab);
                var panel = GameObject.Find("Panel");
                for (int j=0; j<4; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (c1 == 0)
                        {
                            c1++;
                            show_order_details(foodName[i]);
                        }
                        else
                            show_order_details(foodPrice[i]);
                    }
                    else
                    {
                        if (c2 == 0)
                        {
                            c2++;
                            show_order_details(foodQuantity[i]);
                        }
                        else
                        {
                            button.transform.position = panel.transform.position;
                            button.GetComponent<RectTransform>().SetParent(panel.transform);
                            string bname = i.ToString();
                            button.GetComponentInChildren<Text>().text = bname;
                            button.GetComponentInChildren<Text>().enabled = false;
                            button.GetComponent<Button>().onClick.AddListener(() => remove_item(bname));
                            button.gameObject.transform.localScale = new Vector3(1, 1, 1);
                        }
                    }
                }
                sum = sum + Convert.ToInt32(foodPrice[i]) * Convert.ToInt32(foodQuantity[i]);
            }
            show_total_price("");
            show_total_price("Total Bill");
            show_total_price(sum.ToString());
            show_total_price("");
        }
    }
    //Remove an Item from the Order
    public void remove_item(string bname)
    {
        int i = Convert.ToInt32(bname);
        for (int j = 0; j < items.Count; j++)
        {
            if (items[j].fname == foodName[i])
            {
                Item item = items[j];
                item.stock = item.stock + Convert.ToInt32(foodQuantity[i]);
                items[j] = item;
                break;
            }
        }
        foodName.RemoveAt(i);
        foodPrice.RemoveAt(i);
        foodQuantity.RemoveAt(i);
        order_items.RemoveAt(i);
        SceneManager.LoadScene("OrderListScene");
    }
    //Show all the items ordered and quantities
    public void show_order_details(string s)
    {
        GameObject totalPrice = (GameObject)Instantiate(textPrefab);
        var panel2 = GameObject.Find("Panel");
        totalPrice.transform.position = panel2.transform.position;
        totalPrice.GetComponent<RectTransform>().SetParent(panel2.transform);
        totalPrice.GetComponentsInChildren<Text>()[0].text = s;
        totalPrice.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
    //Show total cost
    public void show_total_price(string s)
    {
        GameObject totalPrice = (GameObject)Instantiate(textPrefab2);
        var panel2 = GameObject.Find("Panel");
        totalPrice.transform.position = panel2.transform.position;
        totalPrice.GetComponent<RectTransform>().SetParent(panel2.transform);
        totalPrice.GetComponentsInChildren<Text>()[0].text = s;
        totalPrice.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class ShowOrderList : MonoBehaviour
{
    public GameObject textPrefab;
    public GameObject textPrefab2;
    public GameObject buttonPrefab;
    public int sum = 0;
    public void show(List<OrderItems> orders)
    {
        if (orders.Count != 0)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                int c1 = 0, c2 = 0;
                GameObject button = Instantiate(buttonPrefab);
                var panel = GameObject.Find("Panel");
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 == 0)
                    {
                        if (c1 == 0)
                        {
                            c1++;
                            show_order_details(orders[i].fname);
                        }
                        else
                            show_order_details(orders[i].price.ToString());
                    }
                    else
                    {
                        if (c2 == 0)
                        {
                            c2++;
                            show_order_details(orders[i].quantity.ToString());
                        }
                        else
                        {
                            button.transform.position = panel.transform.position;
                            button.GetComponent<RectTransform>().SetParent(panel.transform);
                            string bname = i.ToString();
                            button.GetComponentInChildren<Text>().text = bname;
                            button.GetComponentInChildren<Text>().enabled = false;
                            button.GetComponent<Button>().onClick.AddListener(() => remove_item(orders, bname));
                            button.gameObject.transform.localScale = new Vector3(1, 1, 1);
                        }
                    }
                }
                sum = sum + orders[i].price * orders[i].quantity;
            }
        }
        showtotalbill(sum.ToString());
    }
    public void showtotalbill(string s)
    {
        show_total_price("");
        show_total_price("Total Bill");
        show_total_price(s);
        show_total_price("");
    }
    public void show_order_details(string s)
    {
        GameObject totalPrice = Instantiate(textPrefab);
        var panel2 = GameObject.Find("Panel");
        totalPrice.transform.position = panel2.transform.position;
        totalPrice.GetComponent<RectTransform>().SetParent(panel2.transform);
        totalPrice.GetComponentsInChildren<Text>()[0].text = s;
        totalPrice.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
    public void show_total_price(string s)
    {
        GameObject totalPrice = Instantiate(textPrefab2);
        var panel2 = GameObject.Find("Panel");
        totalPrice.transform.position = panel2.transform.position;
        totalPrice.GetComponent<RectTransform>().SetParent(panel2.transform);
        totalPrice.GetComponentsInChildren<Text>()[0].text = s;
        totalPrice.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
    public void remove_item(List<OrderItems> orders,string bname)
    {
        int index = Convert.ToInt32(bname);
        orders.RemoveAt(index);
        SceneManager.LoadScene("OrderListScene");
    }
}

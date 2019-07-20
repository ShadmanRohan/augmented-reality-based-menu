using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Proyecto26;

public class AddOrders : MonoBehaviour
{
    public InputField quatity;
    static List<string> foodName = new List<string>();
    static List<string> foodQuatity = new List<string>();
    static List<string> foodPrice = new List<string>();
    FoodPrice newfood;
    public GameObject textPrefab;
    public GameObject buttonPrefab;
    string buttonText;
    int toast = 0;
    
    public void get_text(Button btn)
    {
        buttonText = btn.name;
        toast++;
        Debug.Log("Name: "+buttonText);
    }
    public void addOrder()
    {
        if(toast == 0)
        {
            SSTools.ShowMessage("Please Select an food", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        else {
            foodName.Add(buttonText);
            foodQuatity.Add(quatity.text);
            get_object_from_database(buttonText);
        }
    }
    public void add_in_database()
    {
        if(quatity.text == "")
        {
            SSTools.ShowMessage("Please Enter Table No", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        else
        {
            for (int i = 0; i < foodName.Count; i++)
            {
                FoodDetails newfood = new FoodDetails();
                newfood.food = foodName[i];
                newfood.foodQuatity = foodQuatity[i];
                RestClient.Post("https://cse327-ec9ea.firebaseio.com/" + quatity.text + ".json", newfood);
            }
        }
    }
    public void get_object_from_database(string newf)
    {
        newfood = new FoodPrice();
        RestClient.Get<FoodPrice>("https://cse327-ec9ea.firebaseio.com/" + newf + ".json").Then(response => 
        {
            newfood = response;
            foodPrice.Add(response.fprice);
            
        });
    }
    public void Start()
    {
        Scene newscene = SceneManager.GetActiveScene();
        string scenename = newscene.name;
        if (scenename == "OrderListScene")
        {
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
                            show_object(foodName[i]);
                        }
                        else
                            show_object(foodPrice[i]);
                    }
                    else
                    {
                        if (c2 == 0)
                        {
                            c2++;
                            show_object(foodQuatity[i]);
                        }
                        else
                        {
                            button.transform.position = panel.transform.position;
                            button.GetComponent<RectTransform>().SetParent(panel.transform);
                            string bname = i.ToString();
                            button.GetComponentInChildren<Text>().text = bname;
                            button.GetComponentInChildren<Text>().enabled = false;
                            button.GetComponent<Button>().onClick.AddListener(() => OnButtonClick(bname));
                            button.gameObject.transform.localScale = new Vector3(1, 1, 1);
                        }
                    }
                }
                sum = sum + System.Convert.ToInt32(foodPrice[i]) * System.Convert.ToInt32(foodQuatity[i]);
            }
            show_object("Total");
            show_object("=");
            show_object(sum.ToString());
            
        }
    }
    public void OnButtonClick(string bname)
    {
        int i = System.Convert.ToInt32(bname);
        foodName.RemoveAt(i);
        foodPrice.RemoveAt(i);
        foodQuatity.RemoveAt(i);
        SceneManager.LoadScene("OrderListScene");
    }
    public void show_object(string s)
    {
        GameObject totalPrice = (GameObject)Instantiate(textPrefab);
        var panel2 = GameObject.Find("Panel");
        totalPrice.transform.position = panel2.transform.position;
        totalPrice.GetComponent<RectTransform>().SetParent(panel2.transform);
        totalPrice.GetComponentsInChildren<Text>()[0].text = s;
        totalPrice.gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
}

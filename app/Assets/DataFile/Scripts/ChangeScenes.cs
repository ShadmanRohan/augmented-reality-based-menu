using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void menu_list()
    {
        SceneManager.LoadScene("MenuListScene");
    }
    public void oder_list()
    {
        SceneManager.LoadScene("OrderListScene");
    }
}

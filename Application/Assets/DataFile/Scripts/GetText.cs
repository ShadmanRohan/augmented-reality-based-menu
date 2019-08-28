using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
struct TotalItemTable
{
    public int total;
    public int tableno;
}
public class GetText : MonoBehaviour
{
    public string get_link()
    {
        string linkName = File.ReadAllText("dbLink.txt");
        return linkName;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setplaceholder : MonoBehaviour
{
    public GameObject placerholder;
    public void setplacerholder()
    {
        placerholder.GetComponent<InputField>().placeholder.GetComponent<Text>().text = "244";
        placerholder.GetComponent<InputField>().text = "";
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDWSPopup : MonoBehaviour
{
    public GameObject DWSPanel;
    public GameObject InputFieldAktie1;
    public GameObject TextAktie1;
    public GameObject InputFieldAktie2;
    public GameObject TextAktie2;
    public GameObject InputFieldAktie3;
    public GameObject TextAktie3;
    public GameObject InputFieldAktie4;
    public GameObject TextAktie4;
    public GameObject InputFieldAktie5;
    public GameObject TextAktie5;


    public GameObject MasterText;

    public void OpenPanel()
    {
        Debug.Log("triggered");
      //  Debug.Log("Open Panel");
        if(DWSPanel != null)
        {
           
             bool isActive = DWSPanel.activeSelf;
                DWSPanel.SetActive(!isActive);
        }
        InputFieldAktie1.GetComponent<InputField>().text = "";
        InputFieldAktie2.GetComponent<InputField>().text = "";
        InputFieldAktie3.GetComponent<InputField>().text = "";
        InputFieldAktie4.GetComponent<InputField>().text = "";
        InputFieldAktie5.GetComponent<InputField>().text = "";

        TextAktie1.GetComponent<Text>().text = "";
        TextAktie2.GetComponent<Text>().text = "";
        TextAktie3.GetComponent<Text>().text = "";
        TextAktie4.GetComponent<Text>().text = "";
        TextAktie5.GetComponent<Text>().text = "";

    }
}

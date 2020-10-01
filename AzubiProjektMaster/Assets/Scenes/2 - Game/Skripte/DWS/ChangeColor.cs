using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour
{
    public GameObject Inputfield1;
    public GameObject Inputfield2;
    public GameObject Inputfield4;
    public GameObject Inputfield5;
    public GameObject Inputfield3;
    public Color ImFeld;
    public Color AusFeld;
    public void Update()
    {
     
        if(Inputfield1.GetComponent<InputField>().isFocused == true)
        {
             Inputfield1.transform.Find("Text").GetComponent<Text>().color = ImFeld;
           
        }
        if(Inputfield1.GetComponent<InputField>().isFocused == false){
            Inputfield1.transform.Find("Text").GetComponent<Text>().color = AusFeld;
        }
        //__________________________________________________________________________________________
        if (Inputfield2.GetComponent<InputField>().isFocused == true)
        {
            Inputfield2.transform.Find("Text").GetComponent<Text>().color = ImFeld;

        }
        if (Inputfield2.GetComponent<InputField>().isFocused == false)
        {
            Inputfield2.transform.Find("Text").GetComponent<Text>().color = AusFeld;
        }
        //______________________________________________________________________________________________
        if (Inputfield3.GetComponent<InputField>().isFocused == true)
        {
            Inputfield3.transform.Find("Text").GetComponent<Text>().color = ImFeld;

        }
        if (Inputfield3.GetComponent<InputField>().isFocused == false)
        {
            Inputfield3.transform.Find("Text").GetComponent<Text>().color = AusFeld;
        }
        //____________________________________________________________________________________________
        if (Inputfield4.GetComponent<InputField>().isFocused == true)
        {
            Inputfield4.transform.Find("Text").GetComponent<Text>().color = ImFeld;

        }
        if (Inputfield4.GetComponent<InputField>().isFocused == false)
        {
            Inputfield4.transform.Find("Text").GetComponent<Text>().color = AusFeld;
        }
        //_____________________________________________________________________________________________
        if (Inputfield5.GetComponent<InputField>().isFocused == true)
        {
            Inputfield5.transform.Find("Text").GetComponent<Text>().color = ImFeld;

        }
        if (Inputfield5.GetComponent<InputField>().isFocused == false)
        {
            Inputfield5.transform.Find("Text").GetComponent<Text>().color = AusFeld;
        }
        //_____________________________________________________________________________________________
    }

    public void ResetInputField1()
    {
        ResetColor(Inputfield1);
    }
    
    public void ResetColor(GameObject InputField)
    {
        InputField.GetComponent<InputField>().placeholder.GetComponent<Text>().color = AusFeld;
    }

}

 

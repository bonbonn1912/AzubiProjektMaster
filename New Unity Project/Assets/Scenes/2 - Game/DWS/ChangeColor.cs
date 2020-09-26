using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour
{
    public GameObject Inputfield1;
    public Color ImFeld;
    public Color AusFeld;
    public void Update()
    {
        if(Inputfield1.GetComponent<InputField>().isFocused == true)
        {
            Inputfield1.GetComponent<InputField>().placeholder.GetComponent<Text>().color = AusFeld;
            Inputfield1.GetComponent<InputField>().textComponent.color = ImFeld;
        }
        else
        {
            Inputfield1.GetComponent<InputField>().placeholder.GetComponent<Text>().color = AusFeld;

        }
    }


}

 

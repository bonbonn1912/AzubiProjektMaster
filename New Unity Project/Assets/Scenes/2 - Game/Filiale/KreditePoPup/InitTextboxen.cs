using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitTextboxen : MonoBehaviour
{
    public Text Berater;
    public Text Kredite;

    public void initTextboxen()
    {
        Berater.text = GlobalVariables.username;
        Kredite.text = "2";
    }
}

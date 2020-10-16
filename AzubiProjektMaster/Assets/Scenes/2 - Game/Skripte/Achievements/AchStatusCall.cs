using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AchStatusCall : MonoBehaviour
{
    public TextMeshProUGUI Ach1;
    public TextMeshProUGUI Ach2;
    public TextMeshProUGUI Ach3;
    public TextMeshProUGUI Ach4;
    public TextMeshProUGUI Ach5;
    public TextMeshProUGUI Ach6;
    public TextMeshProUGUI Ach7;
    public TextMeshProUGUI Ach8;
    public TextMeshProUGUI Ach9;

    // <sprite=1> => Grauer Coin
    // <sprite=0> => Goldener Coin
    private void Start()
    {
        Ach1.text = "<sprite=1>";
        Ach2.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach3.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach4.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach5.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach6.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
        Ach7.text = "<sprite=1>";
        Ach8.text = "<sprite=1> <sprite=1> <sprite=1> <sprite=1> <sprite=1> ";
    }

    void Update()
    {

    }
}

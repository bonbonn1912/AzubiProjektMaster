using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverText : MonoBehaviour
{
    public GameObject Kredite;
    public GameObject Statistiken;
    public GameObject hoverText;
    // Start is called before the first frame update

    public void Sichtbar()
    {
        if (Kredite != null)
        {
            bool isActive = Kredite.activeSelf;
           Kredite.SetActive(!isActive);
        }
    }

    public void StatsSichtbar()
    {
        if (Statistiken != null)
        {
            bool isActive = Statistiken.activeSelf;
            Statistiken.SetActive(!isActive);
        }
    }

    public void PopUpHoverText()
    {
        if (hoverText != null)
        {
            hoverText.SetActive(!hoverText.activeSelf);
        }
    }
}

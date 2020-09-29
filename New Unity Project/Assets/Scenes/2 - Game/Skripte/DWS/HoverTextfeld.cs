using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextfeld : MonoBehaviour
{

    public GameObject AktienHandelText;
    public void TextSichtbar()
    {
        if(AktienHandelText != null)
        {
            bool isActive = AktienHandelText.activeSelf;
            AktienHandelText.SetActive(!isActive);
        }
    }
}

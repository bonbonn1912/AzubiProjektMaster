using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverTextfeld : MonoBehaviour
{

    public GameObject AktienHandelText;
    public GameObject BloombergText;
    public void TextSichtbar()
    {
        if(AktienHandelText != null)
        {
            bool isActive = AktienHandelText.activeSelf;
            AktienHandelText.SetActive(!isActive);
        }
    }

    public void BloomBergSichtbar()
    {
        if(BloombergText != null)
        {
            bool isActive = BloombergText.activeSelf;
            BloombergText.SetActive(!isActive);
        }
    }
}

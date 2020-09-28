using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigurPopUp : MonoBehaviour
{
    public GameObject FigurUL;
    public GameObject FigurMid;
    public GameObject FigurUR;
    void Start()
    {
        if (FigurUL != null)
        {
            bool isActive = FigurUL.activeSelf;
            FigurUL.SetActive(!isActive);
        }
    }

    public void FigurMitte()
    {
         if (FigurUL != null)
         {
             bool isActive = FigurUL.activeSelf;
             FigurUL.SetActive(!isActive);

        }

        if (FigurMid != null)
        {
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);
        }
    }

    public void FigurUntenRechts()
    {
        if (FigurMid != null)
        {
            bool isActive = FigurMid.activeSelf;
            FigurMid.SetActive(!isActive);

        }

        if (FigurUR != null)
        {
            bool isActive = FigurUR.activeSelf;
            FigurUR.SetActive(!isActive);
        }
    }


}


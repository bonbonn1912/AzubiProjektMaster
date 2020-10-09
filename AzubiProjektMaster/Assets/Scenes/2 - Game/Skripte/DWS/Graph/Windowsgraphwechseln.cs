using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowsgraphwechseln : MonoBehaviour
{
    public GameObject Window1;
    public GameObject Window2;

    public void Window1oeffnen()
    {
        Window2.SetActive(false);
        Window1.SetActive(true);

    }

    public void Window2oeffnen()
    {
        Window2.SetActive(true);
        Window1.SetActive(false);
    }
}

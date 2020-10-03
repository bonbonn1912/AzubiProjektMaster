using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{

    public GameObject Newspaper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    public void TriggerCo()
    {
        StartCoroutine(EventTimer());
    }

    IEnumerator EventTimer()
    {
        Newspaper.SetActive(true);
        yield return new WaitForSeconds(5);
        Newspaper.SetActive(false);
    }
}

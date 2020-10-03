using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvents : MonoBehaviour
{
    public GenerateEvent Generate;
    public GameObject Newspaper;
    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    public void TriggerCo()
    {
        Generate.TriggerDecision();
        StartCoroutine(EventTimer());
    }

    IEnumerator EventTimer()
    {
        Newspaper.SetActive(true);
        yield return new WaitForSeconds(5);
        Newspaper.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseNewspaper : MonoBehaviour
{
    public static bool coroutineAllowed;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Awake()
    {
        coroutineAllowed = true;
        StartCoroutine(StartPulsing());
    }

   



    public IEnumerator StartPulsing()
    {
        coroutineAllowed = false;
       
        for(int j = 0; j<1000; j++)
        {
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localScale = new Vector3(
                    (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                    (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                    (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.025f, Mathf.SmoothStep(0f, 1f, i)))


                    );
                yield return new WaitForSeconds(0.04f);
            }
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                transform.localScale = new Vector3(
                    (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                    (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                    (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.025f, Mathf.SmoothStep(0f, 1f, i)))


                    );
                yield return new WaitForSeconds(0.04f);
            }
        }
            
           
       coroutineAllowed = true;
    }

}

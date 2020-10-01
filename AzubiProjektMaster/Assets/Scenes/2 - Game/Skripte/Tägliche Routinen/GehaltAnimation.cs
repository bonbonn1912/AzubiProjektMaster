using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GehaltAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().GetComponent<Renderer>().sortingLayerName = "particles";
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.day%2 == 0)
        {
            Debug.Log("30 days");
        }
        {

        }
    }
}

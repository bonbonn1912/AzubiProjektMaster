using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDynamicGraphGameObject : MonoBehaviour
{
    public GameObject DynamicGraph;

    public void open()
    {
        bool isAcitve = DynamicGraph.activeSelf;
        DynamicGraph.SetActive(!isAcitve);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    public bool ZoomHR;
    public Vector3[] Target;

    public Camera Cam;
    public float Speed;
    public float Zoom;


    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
    }


    public void ZoomAufHR()
    {
        ZoomHR = true;
    }
  public void LateUpdate()
    {
        if(ZoomHR == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[1], Speed);

        }
        else
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 190, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    //public bool ZoomActive;
    public static bool ZoomActiveT0 = false;
    public static bool ZoomActiveT1 = false;
    public static bool ZoomActiveT2 = false;
    public static bool ZoomActiveT3 = false;
    public static bool ZoomActiveT4 = false;
   


    public Vector3[] Target;

    public Camera Cam;
    public static float Speed = 0.009f;
    public static float Zoom  = 80;



    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
    }



    //LateUpdate is called when active with every frame update
    public void LateUpdate()
    {
        //Testfunktion für die Kamera
        /* if (ZoomActive)
         {
             Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
             Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[1], Speed);
         }

         else
         {
             Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 190, Speed);
             Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);

         }*/


        if (ZoomActiveT0 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);
        }


        if (ZoomActiveT1 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[1], Speed);

        }

        if (ZoomActiveT2 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[2], Speed);
        }

        if (ZoomActiveT3 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[3], Speed);
        }

        if (ZoomActiveT4 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[4], Speed);
        }
    }
}
//IT Zoom 60
//DWS Zoom 50

//Standart Cam
/*else
{
    Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 190, Speed);
    Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);
}*/
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

    public GameObject filialFigur;
    public GameObject itFigur;
    public GameObject hrFigur;
    public GameObject dwsFigur;

    private List<GameObject> figurList;

    public List<Vector3> target;

    public Camera Cam;
    public static float Speed = 0.009f;
    public static float Zoom  = 80;


    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;

        target.Add(new Vector3(10, -101, -1)); //middle of screen
        figurList = new List<GameObject>() { filialFigur, itFigur, hrFigur, dwsFigur };
        foreach (GameObject obj in figurList)
        {
            Vector3 v = new Vector3(obj.GetComponent<Transform>().position.x, obj.GetComponent<Transform>().position.y + 15, -1);
            target.Add(v);
        }
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
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, target[0], Speed);
        }


        if (ZoomActiveT1 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, target[1], Speed);

        }

        if (ZoomActiveT2 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, target[2], Speed);
        }

        if (ZoomActiveT3 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, target[3], Speed);
        }

        if (ZoomActiveT4 == true)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, Zoom, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, target[4], Speed);
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
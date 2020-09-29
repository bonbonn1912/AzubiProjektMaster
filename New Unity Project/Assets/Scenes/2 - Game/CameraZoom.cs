using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{

    public bool ZoomActive;
    public Vector3[] Target;

    public Camera Cam;
    public float Speed;
    public float Zoom;

    
    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main; 
    }

    public void LateUpdate()
    {
        if(ZoomActive)
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

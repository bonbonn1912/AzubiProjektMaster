using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour
{

    public string scenetochange = "MitarbeiterFenster";

    private void OnMouseDown() => SceneManager.LoadScene(scenetochange);


}

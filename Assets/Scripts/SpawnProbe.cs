using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnProbe : MonoBehaviour
{
    public Controller player;
    public Transform point;
    public Button boton;
    public Text texto;

    private void FixedUpdate()
    {
        player = FindObjectOfType<Controller>();
        if (player != null)
        {
            boton.enabled = false;
            texto.enabled = false;
        }
        if (player == null) 
        { 
            boton.enabled = true; 
            texto.enabled = true; 
        }
    }

    public void Spawn (GameObject go)
    {
        Instantiate(go, point.position, Quaternion.identity);
    }
}

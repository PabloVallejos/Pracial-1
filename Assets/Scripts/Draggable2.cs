using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable2 : MonoBehaviour
{
    public bool drag;

    private void FixedUpdate()
    {
        if (drag == true)
        {

        }
    }

    public void Interact()
    {
        drag = true;
    }
}

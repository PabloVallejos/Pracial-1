using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Controller>().enabled = false;
            other.GetComponent<Dragger>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Controller>().enabled = true;
            other.GetComponent<Dragger>().enabled = true;
        }
    }
}

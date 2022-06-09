using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    public void Dragging(GameObject rb)
    {
        rb.GetComponent<Draggable>().Interact();
    }

    public void Draggn(GameObject go)
    {
        go.transform.SetParent(this.transform, true);
    }

    public void DisDraggn(GameObject go)
    {
        go.transform.SetParent(null);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Interact"))
        {
            if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
            {
                Draggn(other.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interact"))
        {
            DisDraggn(other.gameObject);
            other.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }


}

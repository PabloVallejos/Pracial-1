using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public GameObject player;
    bool dragged = false;

    private void FixedUpdate()
    {
        /*if (dragged == true)
        {
            Debug.Log("Dragged");
            this.GetComponent<Rigidbody>().mass = 0.1f;
            this.gameObject.AddComponent<FixedJoint>();
            this.GetComponent<FixedJoint>().connectedBody = FindObjectOfType<Controller>().GetComponent<Rigidbody>();
        }*/
        if(dragged == false)
        {
            Debug.Log("Undragged");
            this.GetComponent<Rigidbody>().drag = 0;
            Destroy(this.gameObject.GetComponent<FixedJoint>());
        }
    }

    public void Interact()
    {
        dragged = true;
        Debug.Log("Dragged");
        this.gameObject.GetComponent<Rigidbody>().drag = 1;
        this.gameObject.AddComponent<FixedJoint>();
        this.GetComponent<FixedJoint>().connectedBody = FindObjectOfType<Controller>().GetComponent<Rigidbody>();
    }

    public void DisInteract()
    {
        dragged = false;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.LeftControl))
        {
            dragged = true;
        } else { dragged = false; }
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Device : MonoBehaviour
{
    public GameObject og;
    public Transform p;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interact"))
        {
            collision.gameObject.GetComponent<Collider>().enabled = false;
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.transform.position = p.position;
            collision.gameObject.transform.rotation = p.rotation;
            collision.gameObject.transform.parent = p.transform;
            Destroy(og);
        }
    }
}

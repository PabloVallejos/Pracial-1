using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private Transform targetPosition;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //rb.velocity = transform.forward * speed * Time.deltaTime;
            rb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //rb.velocity = transform.forward * -speed * Time.deltaTime;
            rb.AddForce(transform.forward * -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate( new Vector3(0, -1, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.zero;
        }

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Interact") && Input.GetKey(KeyCode.LeftControl))
        {
            collision.gameObject.GetComponent<Draggable>().Interact();
        }
    }*/
}

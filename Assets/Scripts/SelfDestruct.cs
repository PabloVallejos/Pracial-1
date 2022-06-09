using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public Controller player;

    void FixedUpdate()
    {
        player = FindObjectOfType<Controller>();
    }

    public void Kamikaze()
    {
        Destroy(player.gameObject);
    }
}

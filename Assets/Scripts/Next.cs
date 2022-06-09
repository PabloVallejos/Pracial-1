using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public string next;

    private void OnTriggerEnter(Collider other)
    {
        ChangeScene(next);
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Close()
    {
        Application.Quit();
    }
}

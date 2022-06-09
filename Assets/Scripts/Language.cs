using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    public int lan;


    private void FixedUpdate()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void ChangeLang(int lang)
    {
        lan = lang;
    }
}

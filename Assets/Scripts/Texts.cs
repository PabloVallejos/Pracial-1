using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public Text texto;
    public Language lang;
    [TextArea] public string TE;
    [TextArea] public string TS;

    private void Awake()
    {
        lang = FindObjectOfType<Language>();
        texto = this.gameObject.GetComponent<Text>();
    }
    private void FixedUpdate()
    {
        if (lang.lan == 1)
        {
            texto.text = TS;
        }
        if (lang.lan == 2)
        {
            texto.text = TE;
        }
    }
}

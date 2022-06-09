using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImg : MonoBehaviour
{
    public Button manual;

    public void LoadImage(Button img)
    {
        Button bot = Instantiate(img);
        bot.transform.SetParent(FindObjectOfType<Canvas>().transform);
        bot.transform.position = FindObjectOfType<Canvas>().transform.position;
        Destroy(this.gameObject);
    }

    public void StoreManual(Button img)
    {
        Button bot = Instantiate(img);
        bot.transform.SetParent(FindObjectOfType<Canvas>().transform);
        bot.transform.position = FindObjectOfType<Canvas>().transform.position + new Vector3(-380,-270,0);
        Destroy(this.gameObject);
    }
}

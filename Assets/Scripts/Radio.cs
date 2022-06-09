using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public AudioSource sauce;
    public AudioClip[] clips;
    public Image img;
    public Sprite[] imgs;
    private int track;

    private void Start()
    {
        track = 0;
    }

    private void FixedUpdate()
    {
        sauce = FindObjectOfType<AudioSource>();
        if (track > clips.Length)
        {
            track = 0;
        }
        if (track > 0)
        {
            img.sprite = imgs[1];
        } else { img.sprite = imgs[0]; }
        Debug.Log(track);
    }

    public void ChangeClip()
    {
        track++;
        if (track > clips.Length)
        {
            track = 0;
        }
        sauce.clip = clips[track];
        sauce.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonSound : MonoBehaviour
{
    public AudioSource menuButtonSFX;
    public AudioClip hoverSFX;
    public AudioClip clickSFX;

    public void HoverSound()
    {
        //Play hoverSFX once -Arvid
        menuButtonSFX.PlayOneShot (hoverSFX);
    }
    public void ClickSound()
    {
        //Play clickSFX once -Arvid
        menuButtonSFX.PlayOneShot(clickSFX);
    }

}

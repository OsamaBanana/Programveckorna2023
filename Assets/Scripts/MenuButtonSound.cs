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
        menuButtonSFX.PlayOneShot (hoverSFX);
    }
    public void ClickSound()
    {
        menuButtonSFX.PlayOneShot(clickSFX);
    }

}

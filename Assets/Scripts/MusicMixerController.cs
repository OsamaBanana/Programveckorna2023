using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MusicMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer musicAudioMixer;

    public void SetVolume(float sliderValue)
    {
        musicAudioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }
}

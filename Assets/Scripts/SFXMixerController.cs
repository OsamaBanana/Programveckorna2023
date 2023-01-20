using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SFXMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer sfxAudioMixer;

    public void SetVolume(float sliderValue)
    {
        sfxAudioMixer.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);
    }
}

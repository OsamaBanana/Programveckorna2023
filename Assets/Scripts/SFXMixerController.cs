using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SFXMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer sfxAudioMixer;

    //Sets volume depending on slider value -Arvid
    public void SetVolume(float sliderValue)
    {
        //Sets value of SFXVolume and converts liner scale to a logorithmic -Arvid
        sfxAudioMixer.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);
    }
}

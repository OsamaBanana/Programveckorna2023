using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MusicMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer musicAudioMixer;

    //Sets volume depending on slider value -Arvid
    public void SetVolume(float sliderValue)
    {
        //Sets value of MusicVolume and converts liner scale to a logorithmic -Arvid
        musicAudioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }
}

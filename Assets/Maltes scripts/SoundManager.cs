using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //Malte
    [SerializeField] Slider volumeSlider;
    //variabel för en Slider som reglerar generalla volymen

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("sound"))
        {
            PlayerPrefs.SetFloat("sound", 1);
            Load();
        }
        else
        {
            Load();
        }
        // Först kollar koden om spelaren har ändrat volymen förut, om spelaren ändrat volymen tidigare laddar koden värdet på spelarens förra inställningar
        // Om spelaren inte tidigare har ändrat volymen börjar volymen på 100%
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        //När man drar i slider ändras volymen, sedan sparas den vilket gör att man kan återgå till spelet och behålla volymen
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("sound");
        //Används när man ska ladda in spelarens tidigare inställningar för volymen
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("sound", volumeSlider.value);
        //Används när man ska spara spelarens tidigare inställningar för volymen
    }
}
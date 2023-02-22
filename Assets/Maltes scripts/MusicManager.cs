using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{
    //Malte
    [SerializeField] Slider volumeSlider;
    //variabel för en Slider som reglerar volymen för musiken

    // Start is called before the first frame update
    void Start()    
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    // Först kollar koden om spelaren har ändrat musikvolymen förut, om spelaren ändrat volymen tidigare laddar koden värdet på spelarens förra inställningar
    // Om spelaren inte tidigare har ändrat volymen börjar musikvolymen på 100%
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        //När man drar i slider ändras musikvolymen, sedan sparas den vilket gör att man kan återgå till spelet och behålla volymen
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        //Används när man ska ladda in spelarens tidigare inställningar för musikens volym
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
        //Används när man ska spara spelarens tidigare inställningar för musikens volym
    }
}
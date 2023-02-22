using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //Malte
    [SerializeField] Slider volumeSlider;
    //variabel f�r en Slider som reglerar generalla volymen

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
        // F�rst kollar koden om spelaren har �ndrat volymen f�rut, om spelaren �ndrat volymen tidigare laddar koden v�rdet p� spelarens f�rra inst�llningar
        // Om spelaren inte tidigare har �ndrat volymen b�rjar volymen p� 100%
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        //N�r man drar i slider �ndras volymen, sedan sparas den vilket g�r att man kan �terg� till spelet och beh�lla volymen
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("sound");
        //Anv�nds n�r man ska ladda in spelarens tidigare inst�llningar f�r volymen
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("sound", volumeSlider.value);
        //Anv�nds n�r man ska spara spelarens tidigare inst�llningar f�r volymen
    }
}
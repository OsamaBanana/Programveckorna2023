using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{
    //Malte
    [SerializeField] Slider volumeSlider;
    //variabel f�r en Slider som reglerar volymen f�r musiken

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
    // F�rst kollar koden om spelaren har �ndrat musikvolymen f�rut, om spelaren �ndrat volymen tidigare laddar koden v�rdet p� spelarens f�rra inst�llningar
    // Om spelaren inte tidigare har �ndrat volymen b�rjar musikvolymen p� 100%
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
        //N�r man drar i slider �ndras musikvolymen, sedan sparas den vilket g�r att man kan �terg� till spelet och beh�lla volymen
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        //Anv�nds n�r man ska ladda in spelarens tidigare inst�llningar f�r musikens volym
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
        //Anv�nds n�r man ska spara spelarens tidigare inst�llningar f�r musikens volym
    }
}
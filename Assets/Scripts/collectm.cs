using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class collectm : MonoBehaviour

{
    public static collectm instance;
    public TextMeshProUGUI text;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //om kod inte aktiv då gör kod aktiv - Erwin
        if (instance == null)
        {
            instance = this;
        }
    }
    public void keyscollect (int keyss)
    {
        //göra så att nummer av nycklar inte gå över 3 och man få det - erwin
        if (score < 3)
        {
            score += keyss;
            text.text = score.ToString()+"/3";
        }
       
    }
}

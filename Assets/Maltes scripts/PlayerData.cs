using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

//kod som inte fungerar, var t�nkt f�r att spara postionen spelaren sparade vid s� att man kan ladda den n�sta g�ng man g�r in p� spelet - Malte

public class PlayerData : MonoBehaviour
{
    public float[] position;

    public PlayerData (man player)
    {
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.x;
        position[2] = player.transform.position.z;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

//kod som inte fungerar, var tänkt för att spara postionen spelaren sparade vid så att man kan ladda den nästa gång man går in på spelet - Malte

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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

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
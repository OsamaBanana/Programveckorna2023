using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class came : MonoBehaviour
{
    public GameObject Player;
    // Update is called once per frame
    void Update()
    {
        transform.position = new(Player.transform.position.x, Player.transform.position.y, transform.position.z);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSounds: MonoBehaviour
{
    [SerializeField] KeyCode up;
    [SerializeField] KeyCode down;
    [SerializeField] KeyCode left;
    [SerializeField] KeyCode right;

    public bool movementKeyPressed;

    public AudioSource grassSound;
    public AudioSource gravelSound;
    public AudioSource floorSound;

    //Function called when player is colliding with a trigger object -Arvid
    void OnTriggerStay2D(Collider2D other)
    {
        if (movementKeyPressed)
        {
            //Checks if player is colliding with object tagged "Grass" and if grassSound is not already playing -Arvid
            if (other.tag == "Grass" && !grassSound.isPlaying)
            {
                //Sets random pitch and volume of each individual play of the sound between these ranges, then plays sound -Arvid
                grassSound.volume = Random.Range(0.9f, 1);
                grassSound.pitch = Random.Range(0.95f, 1.05f);
                grassSound.Play();
            }
            //Checks if player is colliding with object tagged "Gravel" and if gravelSound is not already playing -Arvid
            else if (other.tag == "Gravel" && !gravelSound.isPlaying)
            {
                //Sets random pitch and volume of each individual play of the sound between these ranges, then plays sound -Arvid
                gravelSound.volume = Random.Range(0.9f, 1);
                gravelSound.pitch = Random.Range(0.95f, 1.05f);
                gravelSound.Play();
            }
            //Checks if player is colliding with object tagged "Floor" and if floorSound is not already playing -Arvid
            else if (other.tag == "Floor" && !floorSound.isPlaying)
            {
                //Sets random pitch and volume of each individual play of the sound between these ranges, then plays sound -Arvid
                floorSound.volume = Random.Range(0.9f, 1);
                floorSound.pitch = Random.Range(0.95f, 1.05f);
                floorSound.Play();
            }
        }
    }

    //Function called when player exits a trigger object -Arvid
    void OnTriggerExit2D(Collider2D other)
    {
        if (movementKeyPressed)
        {
            //Checks if collision object was tagged "Grass", and if such, stops playing grassSound -Arvid
            if (other.tag == "Grass")
            {
                grassSound.Stop();
            }
            //Checks if collision object was tagged "Gravel", and if such, stops playing gravelSound -Arvid
            else if (other.tag == "Gravel")
            {
                gravelSound.Stop();
            }
            //Checks if collision object was tagged "Floor", and if such, stops playing floorSound -Arvid
            else if (other.tag == "Floor")
            {
                floorSound.Stop();
            }
        }
    }

    //Checks if a movement key is pressed and accordingly sets movementKeyPressed to true/false -Arvid
    void Update()
    {
        if (Input.GetKey(up) || Input.GetKey(down) || Input.GetKey(left) || Input.GetKey(right))
        {
            movementKeyPressed = true;
        }
        else
        {
            movementKeyPressed = false;
        }
    }
}
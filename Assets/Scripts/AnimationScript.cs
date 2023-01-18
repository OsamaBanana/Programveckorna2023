using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("moveUp", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("moveLeft", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("moveDown", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("moveRight", true);
        }
    }
}
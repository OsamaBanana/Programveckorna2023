using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public AudioSource GravelSound;
    public Rigidbody2D rb;
    public GameObject Player;
    public Animator animator;
    public bool isMoving;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isMoving)
        {
            animator.SetBool("moveUp", true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private float horizontal;
    private Animator animation;
    
    void Start()
    {
        animation = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animation.SetFloat("xSpeed", Mathf.Abs(horizontal));
    }
}

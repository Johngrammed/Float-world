using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private bool isGrounded = false;
    public Transform groundCheck;
    private float groundRadius = 1.4f;
    public LayerMask whatIsGround;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", isGrounded);
        anim.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.magnitude);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -12f)
        {
            Destroy(gameObject);
        }
    }
}

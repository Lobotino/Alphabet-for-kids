using System;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb2d;
    public float playerSpeed;
    public float jumpPower;
    private int directionInput;
    private bool facingRight = true;
    private bool isJump;

    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if ((directionInput < 0) && (facingRight))
        {
            Flip();
        }

        if ((directionInput > 0) && (!facingRight))
        {
            Flip();
        }

        isJump = Math.Abs(rb2d.velocity.y) > 0.01;

        animator.SetBool("isRun", directionInput != 0);
        animator.SetBool("isJump", isJump);
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(playerSpeed * directionInput, rb2d.velocity.y);
    }

    public void Move(int InputAxis)
    {
        directionInput = InputAxis;
    }

    public void Jump()
    {
        if (!isJump)
        {
            isJump = true;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        var transform1 = transform;
        Vector3 theScale = transform1.localScale;
        theScale.x *= -1;
        transform1.localScale = theScale;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D TheRb;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheckPoint;
    public LayerMask whatIsGround;

    private bool doubleJump;

    private Animator anim;
    private SpriteRenderer theSr;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        theSr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        TheRb.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), TheRb.velocity.y);

        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, .2f, whatIsGround);

        if (isGrounded)
        {
            doubleJump = true;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if(DialogManager.isActive == true)
            {
                return ;
            }
            else
            {
                if (isGrounded)
                {
                    TheRb.velocity = new Vector2(TheRb.velocity.x, jumpForce);
                }
                else
                {
                    if (doubleJump)
                    {
                        TheRb.velocity = new Vector2(TheRb.velocity.x, jumpForce);
                        doubleJump = false;
                    }
                }
            }
            

        }
        if (TheRb.velocity.x < 0)
        {
            theSr.flipX = true;

        }
        else if(TheRb.velocity.x > 0){
            
            theSr.flipX = false;

        }

        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("moveSpeed", Mathf.Abs(TheRb.velocity.x));
    }
}


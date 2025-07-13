
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    [SerializeField] private LayerMask Ground;
    private BoxCollider2D col;
    public float RunSpeed = 8f;
    public float JumpSpeed = 13;
    [SerializeField] private Joystick joystick;

    //private float x;






    
    public enum Movementstate { idle, running, jumpimg, falling }

    // Start is called before the first frame update
    void Start()
    {
   

        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();



    }

    // Update is called once per frame
    void Update()
    {

          float Horizontalinput = joystick.Horizontal;

          rb.velocity = new Vector2(Horizontalinput * RunSpeed, rb.velocity.y);

      

        Horizontalinput = 0;

        if (Input.GetButtonDown("Jump") && Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
        }

        

        Animationupdate();
    }

    public void PlayerFrezze()
    {
        rb.velocity = new Vector2(0, 0);
    }

    public void left()
    {
        rb.velocity = new Vector2(-RunSpeed, rb.velocity.y); 
    }
    public void leftnull()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    public void right()
    {
        rb.velocity = new Vector2(RunSpeed, rb.velocity.y);
    }
    public void rightnull()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
    }
    public void jump()
    {
        if (Grounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
        }
    }



    private  void Animationupdate()
    {

        Movementstate state;
        if (rb.velocity.x > 0.1)
        {
             state = Movementstate.running;
            sprite.flipX = false;
        }
        else if (rb.velocity .x < -0.1)
        {
             state = Movementstate.running;
            sprite.flipX = true;
        }
        else
        {
           // anim.SetBool("Running", false);
           state  = Movementstate.idle;
        }
        if (rb.velocity.y > 0.1)
        {
            state = Movementstate.jumpimg ;
        }
        if (rb.velocity.y < -0.1)
        {
            state = Movementstate.falling;
        }

     
        anim.SetInteger("state",(int)state);
    }

    private bool Grounded()
    {
        return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.down, .1f, Ground);
    }
   
    
}

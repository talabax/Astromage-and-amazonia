using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rB;
    float lastXPushed;
    bool isWalking = false;
    bool isInAir;
    float xVel;
    

    //animation states
    const string moveRight = "moveRight";
    const string moveLeft = "moveLeft";
    const string idleRight = "idleRight";
    const string idleLeft = "idleLeft";
    const string mageJump = "mageJump";
    const string mageJumpLeft = "mageJumpLeft";

    //weapon values
    [SerializeField] GameObject weapon;
    [SerializeField] GameObject spawnWeapon;

    private void Awake()
    {
        rB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        //Debug.Log(lastXPushed);
        JumpingAnimation(xVel);
        Attack(0);

    }

    public void SetGroundTrue()
    {
        isGrounded = true;
        //Debug.Log( "is grounded is true");

    }



    

    public void SetGroundFalse()
    {
        isGrounded = false;
        //Debug.Log("is grounded is false");
    }






    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        JumpRate();
    }

  
    private void Move()
    {
        float xVel = Input.GetAxisRaw("Horizontal");
        //lastXPushed = ifxVel;
        if(xVel != 0)
        {
            isWalking = true;
            lastXPushed = xVel;
        }
        else 
        {
            isWalking = false;
        }

        Vector3 moveDirection = new Vector3(xVel * Time.deltaTime * 3.9f, 0, 0);
        transform.position += moveDirection;


   


        if (xVel >= 1  && isGrounded == true )
        {
            
            MovingRightAnimation();
          

        }
       
        
       
        if (xVel <= -1  && isGrounded == true )
        {
            MovingLeftAnimation();
           
            
        }
        

        if (lastXPushed == 1  && isWalking == false && isGrounded == true)
        {
            IdleRightAnimation();

        }
       
        if (lastXPushed == -1 && isWalking == false && isGrounded == true)
        {
            IdleLeftAnimation();

        }

        

    }

    void JumpRate()
    {
        if (rB.velocity.y < 0)
        {
            rB.gravityScale = 2.3f;
        }
        else
        {
            rB.gravityScale = 2f;

        }


    }

    void MovingLeftAnimation()
    {
        animator.Play(moveLeft);

    }

    void MovingRightAnimation()
    {
        animator.Play(moveRight);

    }

    void IdleRightAnimation()
    {
        animator.Play(idleRight);

    }

    void IdleLeftAnimation()
    {
        animator.Play(idleLeft);

    }

    void JumpingAnimation( float xVel)
    {

        


        if (Input.GetButtonDown("Jump") && isGrounded == true  && lastXPushed == 1)
        {

            rB.AddForce(new Vector2(0, 8f), ForceMode2D.Impulse);
            animator.Play(mageJump);

            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded == true  && lastXPushed == -1)
        {
            rB.AddForce(new Vector2(0, 8f), ForceMode2D.Impulse);
            animator.Play(mageJumpLeft);

            isGrounded = false;
        }





    }

    void Attack(int attackMod)
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("attack has been made");
            SpawnWeapon();

        }



    }

    void SpawnWeapon()
    {
        // GameObject projectile = Instantiate(weapon,spawnWeapon.transform.position ,Quaternion.identity) as GameObject;
        GameObject projectile = Instantiate(weapon, transform.position, Quaternion.identity) as GameObject;

    }



    public float GetFacingDirection()
    {
        return lastXPushed;

    }





}
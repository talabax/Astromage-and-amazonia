using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDirections : MonoBehaviour
{
    Rigidbody2D proj;
    Movement facingDirection;
    float direction;
    Animator starRot;

    int starDamage = 10;

    float damModifier;

    private void Start()
    {
        FireProjectile(direction);
        starRot.Play("starRotation");
    }

    private void Awake()

    {
        
        


        starRot = GetComponent<Animator>();
        proj = GetComponent<Rigidbody2D>();

        facingDirection = FindObjectOfType<Movement>();
        direction = facingDirection.GetFacingDirection();

    }
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
       // Debug.Log(direction);

    }


    void FireProjectile(float dir)
    {
        proj.velocity = new Vector2(dir*10, 0);


    }

    public int Damage()
    {
        return starDamage;

    }


}

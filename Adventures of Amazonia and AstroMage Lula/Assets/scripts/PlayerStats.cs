using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    int startingHealth = 1000;
    int curentHealth;


    // Start is called before the first frame update
    void Start()
    {
        curentHealth = startingHealth;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void PlayerDeath()
    {
        //death animation
        Destroy(gameObject);


    }

    public void PlayerTakesDamage( int amount)
    {
        curentHealth = curentHealth - amount;
        if (curentHealth <= 0)
        {
            PlayerDeath();
        }

    }

    public void PlayerGainsLife(int amount)
    {
        curentHealth = curentHealth + amount;



    }






}

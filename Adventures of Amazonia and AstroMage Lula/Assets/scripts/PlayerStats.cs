using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    int startingHealth = 1000;
    int curentHealth;
    int startingMana = 100;
    int curentMana;
    DamageEffects damageEffects;

    // Start is called before the first frame update
    void Start()
    {
        damageEffects = FindObjectOfType<DamageEffects>();
        curentHealth = startingHealth;
        curentMana = startingMana;
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
        damageEffects.DamageWarning();
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


    public int PlayerLife()
    {

        return curentHealth;


    }

    public int PlayerMana()
    {

        return curentMana;


    }

}

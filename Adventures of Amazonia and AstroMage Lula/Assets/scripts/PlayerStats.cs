using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    int startingHealth = 1000;
    int currentHealth;
    
    int startingMana = 100;
    int currentMana;
    bool result;


    DamageEffects damageEffects;

    // Start is called before the first frame update
    void Start()
    {
        damageEffects = FindObjectOfType<DamageEffects>();
        currentHealth = startingHealth;
        currentMana = startingMana;
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
        currentHealth = currentHealth - amount;
        if (currentHealth <= 0)
        {
            PlayerDeath();
        }

    }

    public void PlayerGainsLife(int amount)
    {
        currentHealth = currentHealth + amount;



    }


    public int PlayerLife()
    {

        return currentHealth;


    }




    //handle mana



    public void PlayerGainsMana(int amount)
    {
        currentMana = currentMana + amount;



    }


    public int PlayerMana()
    {

        return currentMana;


    }

    public bool PlayerLosesMana(int amount)
    {
        if( amount <= currentMana)
        {
            currentMana = currentMana - amount;

            result = true;
        }
        else if (amount > currentMana)
        {
            result= false;  
        }

        return result;
    }



}

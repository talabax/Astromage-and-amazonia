using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class LivesData : ScriptableObject
{

     public int startingHealth = 100;
     public int currentHealth;
  
    public int startingLives = 5;
    public int currentLives;

     public bool gameHasStarted = false;


    public int CurrentLife()
    {
       return currentHealth;

    }

    public int CurrentLives()
    {
        return currentLives;
    }


    public int StartingtLives()
    {
        currentLives = startingLives;
        return currentLives;

    }

    public void RemoveLives()
    {
        Debug.Log("FFFFFFFFFFFFFFFFFFF");

        currentLives = currentLives - 1;
        startingLives = currentLives;
       // Debug.Log("life Lost" + currentLives);

    }

}

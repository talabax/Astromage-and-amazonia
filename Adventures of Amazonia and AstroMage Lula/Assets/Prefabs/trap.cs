using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    PlayerStats thePlayer;
    private void Awake()
    {
        thePlayer = FindObjectOfType<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            thePlayer.PlayerDeath();
        }
    }





}

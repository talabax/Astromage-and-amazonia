using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    PlayerStats thePlayer;
    DamageEffects damageEffects;
    private void Awake()
    {
        damageEffects = FindObjectOfType<DamageEffects>();
        thePlayer = FindObjectOfType<PlayerStats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            damageEffects.DamageWarning();
            thePlayer.PlayerDeath();
        }
    }





}

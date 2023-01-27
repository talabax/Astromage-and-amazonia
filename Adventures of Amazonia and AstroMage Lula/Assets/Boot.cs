using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update

    PlayerStats thePlayer;
    DamageEffects damageEffects;
    private void Awake()
    {
        damageEffects = FindObjectOfType<DamageEffects>();
        thePlayer = FindObjectOfType<PlayerStats>();
    }




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(-2, 10), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //damageEffects.DamageWarning();
            thePlayer.PlayerTakesDamage(10);
        }


    }




}
